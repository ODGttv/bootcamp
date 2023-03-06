using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampPrep
{
    public class MonsterTypeB : IMyInterface
    {
        private string name;
        private int number;
        private Element type;
        private Element altType;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public Element Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public Element AltType
        {
            get
            {
                return altType;
            }
            set
            {
                altType = value;
            }
        }

        public string Evolve(string newName)
        {
            string toReturn = string.Format("{0} done gone turnt into {1} somehow!", this.Name, newName);
            this.Name = newName;
            this.Number = this.number + 1;
            return toReturn;
        }

        public override string ToString()
        {
            return string.Format("{0} is number {1} and types {2} and {3}.", name, number, type.ToString(), altType.ToString());
        }
    }
}
