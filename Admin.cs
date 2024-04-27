using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineSystem
{
    /// <summary>
    /// Contains the Data for the admin And methods to Validate the data
    /// </summary>
    internal static class Admin
    {
        private static string id = "11223344";
        private static string Password = "SHA@FileProject";
        /// <summary>
        /// Validates input data with stored data in the Admin Class
        /// </summary>
        /// <param name="id">ID of Admin</param>
        /// <param name="password">Password that match with data in class</param>
        /// <returns>true if the data is valid, false if the data is invalid</returns>
        public static bool Validate(string id,string password)
        {
            if (Admin.id == id && Admin.Password == password)
            {
                return true;
            }
            else return false;
        }
    }
}
