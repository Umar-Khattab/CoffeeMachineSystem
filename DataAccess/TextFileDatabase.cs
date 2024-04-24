using System;
using System.Collections.Generic;
using System.IO;

namespace CoffeeMachineSystem.DataAccess
{
    internal class TextFileDatabase
    {
        private readonly string filePath;

        /// <summary>
        /// Initializes a new instance of the TextFileDatabase class with the specified file path.
        /// </summary>
        /// <param name="filePath">The path to the text file used as the database.</param>
        public TextFileDatabase(string filePath)
        {
            this.filePath = filePath;
        }

        /// <summary>
        /// Inserts a new record into the text file database.
        /// </summary>
        /// <param name="record">The record to insert into the database.</param>
        public void Insert(string record)
        {
            using FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            using StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(record);
        }

        /// <summary>
        /// Reads all records from the text file database.
        /// </summary>
        /// <returns>A list containing all records read from the database.</returns>
        public List<string> Read()
        {
            List<string> records = new List<string>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                {
                    records.Add(sr.ReadLine());
                }
            }

            return records;
        }

        /// <summary>
        /// Reads the specified field of a record from the text file database based on the specified ID.
        /// </summary>
        /// <param name="id">The ID of the record to read.</param>
        /// <param name="fieldIndex">The index of the field to read within the record.</param>
        /// <param name="separator">The character used to separate fields in the records.</param>
        /// <returns>The value of the specified field.</returns>
        public string ReadFieldById(int id, int fieldIndex, char separator)
        {
            using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using StreamReader sr = new StreamReader(fs);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] fields = line.Split(separator);
                if (fields.Length > fieldIndex && int.Parse(fields[0]) == id)
                {
                    return fields[fieldIndex];
                }
            }

            return null;
        }

        /// <summary>
        /// Deletes a record from the text file database based on the specified ID.
        /// </summary>
        /// <param name="id">The ID of the record to delete.</param>
        /// <param name="separator">The character used to separate fields in the records.</param>
        public void Delete(int id, char separator)
        {
            List<string> records = Read();

            records.RemoveAll(r => int.Parse(r.Split(separator)[0]) == id);

            WriteAllRecords(records);
        }

        /// <summary>
        /// Updates a specific field of a record in the text file database based on the specified ID and field index.
        /// </summary>
        /// <param name="id">The ID of the record to update.</param>
        /// <param name="fieldIndex">The index of the field to update within the record.</param>
        /// <param name="newValue">The new value to set for the field.</param>
        /// <param name="separator">The character used to separate fields in the records.</param>
        public void UpdateField(int id, int fieldIndex, string newValue, char separator)
        {
            List<string> records = Read();

            for (int i = 0; i < records.Count; i++)
            {
                string[] fields = records[i].Split(separator);

                if (fieldIndex < fields.Length && int.Parse(fields[0]) == id)
                {
                    fields[fieldIndex] = newValue;
                    records[i] = string.Join(separator, fields);
                    break;
                }
            }

            WriteAllRecords(records);
        }

        /// <summary>
        /// Writes all records to the text file database.
        /// </summary>
        /// <param name="records">The list of records to write to the database.</param>
        private void WriteAllRecords(List<string> records)
        {
            using FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            using StreamWriter writer = new StreamWriter(fs);

            foreach (string record in records)
            {
                writer.WriteLine(record);
            }
        }
    }
}
