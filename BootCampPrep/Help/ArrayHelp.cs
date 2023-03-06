using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampPrep.Help
{
    public static class ArrayHelp
    {
        public static string WriteOut(this int[] ints)
        {
            string toReturn = "{ ";

            for (int i = 0; i < ints.Length; i++)
                toReturn = string.Format("{0}{1}, ", toReturn, ints[i]);

            toReturn = toReturn.Remove(toReturn.Length - 2);
            toReturn = string.Concat(toReturn, " }");

            return toReturn;
        }

        public static string WriteOut(this int[,] ints)
        {
            string toReturn = "{ ";

            for(int i = 0; i < ints.GetLength(0); i++)
            {
                toReturn = string.Concat(toReturn, "{ ");

                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    toReturn = string.Format("{0}{1}, ", toReturn, ints[i,j]);
                }
                toReturn = toReturn.Remove(toReturn.Length - 2);
                toReturn = string.Concat(toReturn, " }");
            }

            toReturn = string.Concat(toReturn, " }");

            return toReturn;
        }

    }
}
