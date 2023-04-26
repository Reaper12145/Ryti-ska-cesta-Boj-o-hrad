using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rytirskacestabojohrad
{
    internal class kral : bytost
    {
        public string jmeno = "Kral";
        public override int uvod()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(1000);
            Console.WriteLine("{0}: Ja už to nezvladám lid se mi ztrácí!", jmeno);
            Thread.Sleep(3000);
            Console.WriteLine("{0}: Zavolejte mi Feudála ", jmeno);
            Thread.Sleep(2000);
            Console.WriteLine("{0}: Milý feudále. Vy víte o tom, že naše království týrá zlý drak. Jste schopen se svými rytíři ho zneškodnit?", jmeno);
            Thread.Sleep(2000);
            Console.WriteLine("{0}: Pro přijmutí zmačkni A pro odmítnutí zmačnki N", jmeno);

            return 0;
        }
        public override int DruhaCast()
            {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Jsem rád že vás mám k dispozici. Jestli to zvládnete nemine vás odměna v podobě jakékoliv ženy nebo pokémona z podhradí. Vkládám do vás budoucnost tohoto království.", jmeno);
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Na cestu jste dostali 400zł");
            Thread.Sleep(3000);
            Console.Clear();
            penize = 400;
            
            
            
            return 0;
            }
    }
}
