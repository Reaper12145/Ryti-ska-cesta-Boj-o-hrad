using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rytirskacestabojohrad
{
    internal class banditi:bytost
    {
        public string jmeno = "Banditi";

        public override int TretiCast()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}: Dejte nám 150zł nebo vás zabijeme.", jmeno);
            Thread.Sleep(2500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pište pouze 1 nebo 2!");
            Thread.Sleep(1000);
            Console.WriteLine("1. Vyjednávat a nabídnout jim 150zł");
            Thread.Sleep(1000);
            Console.WriteLine("2. Vrhnout se přímo na ně.");
            return 0;

        }
    }
}
