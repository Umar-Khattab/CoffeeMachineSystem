using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineSystem
{
    internal static class Admin
    {
        private static string id = "1234";
        private static string Password = "1234";
        public static bool Validation(string id, string password)
        {
            if (Admin.id == id && Admin.Password == password)
            {
                return true;
            }
            else return false;
        }
    }
}
