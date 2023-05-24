using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rytirskacestabojohrad
{
    internal class drak : bytost
    {
        public string jmeno = "Drak";
        public override int DruhaCast()
        {
            Console.WriteLine("{0}: Co vy zde děláte!!!!!!!!", jmeno);
            Thread.Sleep(1000);
            Console.WriteLine("{0}: To je moje království!!!!!!!!!", jmeno);
            Thread.Sleep(1000);
            Console.WriteLine("{0}: Puste mně!!!!!!!!!!!!", jmeno);
            Thread.Sleep(1000);
            Console.WriteLine("{0}: Puste mně nebo na vás pošlu Byrua!!!!!!!!", jmeno);
            Thread.Sleep(1000);
            return 0;
        }
    }
}
