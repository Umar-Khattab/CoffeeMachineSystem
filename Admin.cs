using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineSystem
{
    ///<include file='Resourses\Documentation.xml' path='doc/myMembers/member[@name="Admin"]/admin/*'/>
    internal static class Admin
    {

        private static string id = "11223344";
        private static string Password = "SHA@FileProject";
        /// <include file='Resourses\Documentation.xml' path="doc/myMembers/member[@name='Admin']/validate"/>
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
