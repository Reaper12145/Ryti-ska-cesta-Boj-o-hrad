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
        public int penize = 0; //0-99999999


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


        public int vratpenize()
        {
            return penize;
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


        virtual public int Vypaleni()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }


        virtual public int HodKostkou()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }


        virtual public int Tutorial()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }


        virtual public int Vraceni()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }


        virtual public int DruhaCast()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }


        virtual public int TretiCast()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }


        virtual public int HodKostkoub()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }


        virtual public int Vracenii()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }


        virtual public int CtvrtaCast()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }


        virtual public int PenizeMinus50()
        {
            penize = (penize - 50);
            Console.WriteLine("Aktualni zustatek: ",penize);
            return penize;
        }


        virtual public int PenizeMinus100()
        {
            penize = (penize - 100);
            Console.WriteLine("Aktualni zustatek: ", penize);
            return penize;
        }


        virtual public int PenizeMinus30()
        {
            penize = (penize -30);
            Console.WriteLine("Aktualni zustatek: ", penize);
            return penize;
        }


        virtual public int PenizeMinus128()
        {
            penize = (penize - 128);
            Console.WriteLine("Aktualni zustatek: ", penize);
            return penize;
        }
        virtual public int PenizePlus500()
        {
            penize = (penize + 500);
            Console.WriteLine("Aktualni zustatek: ", penize);
            return penize;
        }


        virtual public int PataCast()
        {
            Console.WriteLine("{0}: ...", jmeno);
            return 0;
        }


        virtual public int SestaCast()
        {
            Console.WriteLine("{0} ...", jmeno);
            return 0;
        }


        virtual public int SedmaCast()
        {
            Console.WriteLine("{0} ...", jmeno);
            return 0;
        }

        virtual public int OsmaCast()
        {
            Console.WriteLine("{0} ...", jmeno);
            return 0;
        }
        virtual public int DevataCast()
        {
            Console.WriteLine("{0} ...", jmeno);
            return 0;
        }
        virtual public int DesataCast()
        {
            Console.WriteLine("{0} ...", jmeno);
            return 0;
        }
        virtual public int JedenastaCast()
        {
            Console.WriteLine("{0} ...", jmeno);
            return 0;
        }
        virtual public int DvanastaCast()
        {
            Console.WriteLine("{0} ...", jmeno);
            return 0;
        }
        virtual public int TrinastaCast()
        {
            Console.WriteLine("{0} ...", jmeno);
            return 0;
        }
        virtual public int CtrnastaCast()
        {
            Console.WriteLine("{0} ...", jmeno);
            return 0;
        }


    }
}
