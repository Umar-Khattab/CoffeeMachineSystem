using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineSystem
{
    ///<include file='Resourses\Documentation.xml' path='doc/myMembers/member[@name="SailedItems"]/SailedItems/*'/>
    internal static class SailedItems
    {
        public static int SailedCoffee { get; private set; } = 0;
        public static int SailedLate { get; private set; } = 0;
        public static int SailedCappuchino { get; private set; } = 0;
        ///<include file='Resourses\Documentation.xml' path='doc/myMembers/member[@name="SailedItems"]/Increment/*'/>
        public static void IncrementSailedCoffee(int quantity)
        {
            SailedCoffee += quantity;
        }
        ///<include file='Resourses\Documentation.xml' path='doc/myMembers/member[@name="SailedItems"]/Increment/*'/>
        public static void IncrementSailedLate(int quantity)
        {
            SailedLate += quantity;
        }
        ///<include file='Resourses\Documentation.xml' path='doc/myMembers/member[@name="SailedItems"]/Increment/*'/>
        public static void IncrementSailedCappuchino(int quantity)
        {
            SailedCappuchino += quantity;
        }
    }
}
