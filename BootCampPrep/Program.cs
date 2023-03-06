using BootCampPrep.Applying_OOP;
using BootCampPrep.Help;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Data types
             */
            string myString = "A string is an sequence of alphanumeric and synbol strings, excluding \\, which is an escape character";
            int myIntOne = 0;
            int myIntTwo = 1 / 2;
            int myIntThree = 999999999;
            bool myBoolean = true;

            Console.WriteLine(myString);
            Console.WriteLine(myIntOne);
            Console.WriteLine(myIntTwo);
            Console.WriteLine(myIntThree);
            

            /*
             * Logic operators
             */
            if (myBoolean)
                Console.WriteLine("My boolean contains a true value.");
            else
                Console.WriteLine("My boolean contains a false value.");

            if(myBoolean == true)
            {
                Console.Write("My Boolean contains a true value.");
            }
            else
                Console.WriteLine("My boolean contains a false value.");

            if (myIntOne == myIntTwo && myIntThree > myIntTwo)
                Console.WriteLine("My third integer's value is greater than my first and second integers' values, which are equivalent.");

            for(int i = 0; i < myIntThree; i++)
            {
                if (i % 10000000 == 0)
                    Console.WriteLine(i);
            }


            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                bool keepGoing = true;
                int counter = 0;
                while (keepGoing)
                {
                    keepGoing = Convert.ToBoolean((random.Next(2)));
                    counter++;
                }
                Console.WriteLine(string.Format("{0} loops", counter));
            }

            Console.ReadLine();

            /*
             * Collections
             */

            List<string> stringList = new List<string>();
            int[] intArray = { 0, 2, 4, 5 };
            int[,] intDoubleArray = { { 0, 0 }, { 1, 1 }, { 163, 4 } };

            stringList.Add("bob");
            stringList.Add("ate");
            stringList.Add("a");
            stringList.Add("hamburger");

            foreach(string word in stringList)
            {
                Console.Write(word + " ");
            }

            stringList.RemoveAt(2);

            foreach (string word in stringList)
            {
                Console.Write(word, " ");
            }

            Console.WriteLine(intArray.WriteOut());
            Console.WriteLine(intDoubleArray.WriteOut());

            intArray[3] = 6;
            Console.WriteLine(intArray.WriteOut());

            intDoubleArray[2, 0] = 3;
            Console.WriteLine(intDoubleArray.WriteOut());

            Console.ReadLine();

            /*
             * OOP
             */

            MyObjectOne oopOne = new MyObjectOne();
            MyObjectOne oopTwo = new MyObjectOne("This is a string");
            MyObjectOne oopThree = new MyObjectOne(100);
            MyObjectOne oopFour = new MyObjectOne("This is another string", 105);

            Console.WriteLine(oopOne.ToString());
            Console.WriteLine(oopTwo.ToString());
            Console.WriteLine(oopThree.ToString());
            Console.WriteLine(oopFour.ToString());

            Console.ReadLine();

            List<IMyInterface> myInterfaces = new List<IMyInterface>();

            MonsterTypeA monsterTypeA = new MonsterTypeA();
            monsterTypeA.Name = "Bulbasaur";
            monsterTypeA.Number = 1;
            monsterTypeA.Type = Element.Grass;

            MonsterTypeB monsterTypeB = new MonsterTypeB();
            monsterTypeB.Name = "Zapdos";
            monsterTypeB.Number = 145;
            monsterTypeB.Type = Element.Electric;
            monsterTypeB.AltType = Element.Flying;

            myInterfaces.Add(monsterTypeA);
            myInterfaces.Add(monsterTypeB);

            foreach(IMyInterface myInterface in myInterfaces)
            {
                Console.WriteLine(myInterface.ToString());
            }

            Console.ReadLine();

            /*
             * Applying OOP
             */

            Console.WriteLine(OOPStuff01.CompareObjects(monsterTypeA, monsterTypeB));
            Console.WriteLine(OOPStuff01.CompareObjects(monsterTypeB, monsterTypeB));

            OOPStuff01.ChangeName(monsterTypeA, "Ivysaur");
            Console.WriteLine(monsterTypeA);
            Console.WriteLine(monsterTypeA.Evolve("Venusaur"));
            Console.WriteLine(monsterTypeB.ExEvolve("something else I don't fucking know"));

            Console.ReadLine();

        }

        
    }

    public class MyObjectOne
    {
        string ObjectString { get; set; }
        int ObjectInt { get; set; }

        public MyObjectOne()
        {
            ObjectString = "no string";
            ObjectInt = 0;
        }

        public MyObjectOne(string newString)
        {
            ObjectString = newString;
            ObjectInt = 0;
        }

        public MyObjectOne(int newInt)
        {
            ObjectString = "no string";
            ObjectInt = newInt;
        }

        public MyObjectOne(string newString, int newInt)
        {
            ObjectString = newString;
            ObjectInt = newInt;
        }

        public override string ToString()
        {
            return string.Format("The Object's string is: {0} \nThe Object's integer is: {1}", ObjectString, ObjectInt);
        }
    }

}
