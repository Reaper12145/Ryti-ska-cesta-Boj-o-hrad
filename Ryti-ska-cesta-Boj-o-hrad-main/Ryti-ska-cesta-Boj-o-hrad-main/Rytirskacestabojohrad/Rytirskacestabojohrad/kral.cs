using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rytirskacestabojohrad
{
    internal class kral:bytost
    {
        public string jmeno = "Kral";
        public override int uvod()
        {
            Thread.Sleep(1000);
            Console.WriteLine("{0}: Ja už to nezvladám lid se mi strácí!", jmeno);
            Thread.Sleep(3000);
            Console.WriteLine("{0}: Zavolejte mi Feudála ", jmeno);
            Thread.Sleep(2000);
            Console.WriteLine("{0}: Milý feudále. Vy víte o tom, že naše království týrá zlý drak. Jste schopen se svými rytíři ho zneškodnit?", jmeno);
            return 0;
        }
    }
}
