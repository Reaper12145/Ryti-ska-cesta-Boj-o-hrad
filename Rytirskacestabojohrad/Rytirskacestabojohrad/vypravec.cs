using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rytirskacestabojohrad
{
    internal class vypravec:bytost
    {
        public string jmeno = "Vypravěč";
        public override int uvod()
        {

            Console.WriteLine("{0}: Vysoko v horách leží tajemný hrad, který byl kdysi sídlem mocného krále.", jmeno);
            Thread.Sleep(5000);
            Console.WriteLine("{0}: Jeho poddaní mu sloužili s oddaností, ale když se na obzoru objevil drak, jejich životy se změnily.", jmeno);
            Thread.Sleep(5500);
            Console.WriteLine("{0}: Drak vybíral výpalné a ničil vesnice.", jmeno);
            Thread.Sleep(3000);
            return 0;
        }

    }
}
