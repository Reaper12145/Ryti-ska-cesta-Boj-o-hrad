using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rytirskacestabojohrad
{
    internal class feudal:bytost
    {
        public string jmeno = "Feudal";
        public override int DruhaCast()
        {
            Console.WriteLine("{0}: Tak a je po něm.", jmeno);
            Thread.Sleep(1500);
            return 0;
        }
        // Co po nás žádáš Králi?
        public override int TretiCast()
        {
            Console.WriteLine("{0}: Co po nás žádáš Králi?", jmeno);
            Thread.Sleep(2000);
            return 0;
        }
    }
}
