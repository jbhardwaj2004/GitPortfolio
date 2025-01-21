using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolarMassCalculator_Tyler_Justin
{
    public class Element
    {
        public string name;
        public string symbol;
        public int atomicNumber;
        public double atomicMass;

        //public Element(string n, string sym, int num, double mass)
        //{
        //    name = n;
        //    symbol = sym;
        //    atomicNumber = num;
        //    atomicMass = mass;
        //}

        public Element(int num, string sym, string n, double mass)
        {
            name = n;
            symbol = sym;
            atomicNumber = num;
            atomicMass = mass;
        }
    }
}
