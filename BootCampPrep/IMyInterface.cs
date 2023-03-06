using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampPrep
{
    public interface IMyInterface
    {
        string Name { get; set; }
        int Number { get; set; }
        Element Type { get; set; }
        string Evolve(string newName);
    }

    public enum Element
    {
        Grass,
        Fire,
        Water,
        Rock,
        Ground,
        Electric,
        Dragon,
        Psychic,
        Fighting,
        Bug,
        Normal,
        Flying,
        Ice
    }
}
