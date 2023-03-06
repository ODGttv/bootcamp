using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampPrep.Applying_OOP
{
    public static class OOPStuff02
    {
        public static string ExEvolve(this IMyInterface myInterface, string newName)
        {
            return myInterface.Evolve(newName);
        }
    }
}
