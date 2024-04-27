using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineSystem
{
    /// <summary>
    /// Class to store the data of the items that are sold by the user
    /// And methods to add the items sold by the user
    /// </summary>
    internal static class SailedItems
    {
        public static int SailedCoffee { get; private set; } = 0;
        public static int SailedLate { get; private set; } = 0;
        public static int SailedCappuchino { get; private set; } = 0;



        /// <summary>
        /// Increments the number of items sold by the user
        /// </summary>
        /// <param name="quantity">Quantity That Passed from user form</param>
        public static void IncrementSailedCoffee(int quantity)
        {
            SailedCoffee += quantity;
        }


        /// <summary>
        /// Increments the number of items sold by the user
        /// </summary>
        /// <param name="quantity">Quantity That Passed from user form</param>
        public static void IncrementSailedLate(int quantity)
        {
            SailedLate += quantity;
        }


        /// <summary>
        /// Increments the number of items sold by the user
        /// </summary>
        /// <param name="quantity">Quantity That Passed from user form</param>
        public static void IncrementSailedCappuchino(int quantity)
        {
            SailedCappuchino += quantity;
        }
    }
}
