using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rytirskacestabojohrad
{
    internal class bytost
    {
        public string jmeno = "bytost";
        public int zivoty = 100; //0-100
        private int inteligence = 4; //0-100
        private int rychlost = 5; //0-100
        private int sila = 10; //0-100
        private int obrana = 4; //0-100
        public int VratInteligenci()
        {
            return inteligence;
        }
        public int VratRychlost()
        {
            return rychlost;
        }
        public int VratSilu()
        {
            return sila;
        }

        virtual public int Pozdrav()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }
        virtual public int uvod()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }

    }
}
