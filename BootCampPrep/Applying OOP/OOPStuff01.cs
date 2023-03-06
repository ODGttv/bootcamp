using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampPrep.Applying_OOP
{
    public static class OOPStuff01
    {
        public static bool CompareObjects(Object obj01, Object obj02)
        {
            try
            {
                return obj01 == obj02;
            }
            catch 
            {
                return false;
            }
        }

        public static void ChangeName(IMyInterface myInterface, string newName)
        {
            myInterface.Name = newName;
        }
    }
}