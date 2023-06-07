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
            Thread.Sleep(2000);
            Console.WriteLine("{0}: Ja už to nezvladám lid se mi ztrácí!", jmeno);
            Thread.Sleep(4000);
            Console.WriteLine("{0}: Zavolejte mi Feudála ", jmeno);
            Thread.Sleep(3000);
            Console.WriteLine("{0}: Milý feudále. Vy víte o tom, že naše království týrá zlý drak. Jste schopen se svými rytíři ho zneškodnit?", jmeno);
            Thread.Sleep(3000);
            Console.WriteLine("{0}: Pro přijmutí zmačkni 1 pro odmítnutí zmačnki 2", jmeno);

            return 0;
        }
        public override int DruhaCast()
            {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Jsem rád že vás mám k dispozici. Jestli to zvládnete nemine vás odměna v podobě jakékoliv ženy nebo pokémona z podhradí. Vkládám do vás budoucnost tohoto království.", jmeno);
            Thread.Sleep(6000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Na cestu jste dostali 400zł");
            Thread.Sleep(3000);
            Console.Clear();

            
            
            
            return 0;
            }
        public override int TretiCast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Proč jsi zlý draku terorizoval moje králvoství? Nikdo ti nic neudělal. ", jmeno);
            Thread.Sleep(4000);
            Console.Clear();

            return 0;
        }
        public override int CtvrtaCast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: To se nikdo nesmí dozvědět!!!", jmeno);
            Thread.Sleep(2000);
            Console.WriteLine("1. Nechat zabít draka");
            Thread.Sleep(2000);
            Console.WriteLine("2. Vyhnat draka z království ");
            return 0;   
        }
        public override int PataCast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Mockrát vám děkuji pánové. Jak jsem slíbil, tak to je. Nyní si můžete vybrat  jakoukoliv ženu či pokémona z podhradí.", jmeno);
            Thread.Sleep(4000);

            return 0;
        }
        public override int SestaCast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Pozvěte mi sem feudála s jeho rytíři. Nutně je potřebujeme!!!", jmeno);
            Thread.Sleep(2000);

            return 0;
        }
        //Král: Sami víte co se zde poslední dobou děje. A proto vás žádám zas a znova o vaši pomoc.
        //Pomoct králi
        //Nepomoct(Vládce podzemí ovládne celé království a všechny rytíře postupně vyvraždí)

        public override int SedmaCast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Sami víte co se zde poslední dobou děje. A proto vás žádám zas a znova o vaši pomoc.", jmeno);
            Thread.Sleep(3000);
            Console.WriteLine("1. Pomoct králi");
            Console.WriteLine("2. Nepomoct");

            return 0;
        }

        public override int OsmaCast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Pokud se vám to i tentokrát povede tak vás odměním několikanásobně více než minule. Vkládám do vás všechny moje naděje.", jmeno);
            Thread.Sleep(4000);
            return 0;
        }
       
        public override int DevataCast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Pokud se vám to i tentokrát povede tak vás odměním několikanásobně více než minule. Vkládám do vás všechny moje naděje.", jmeno);
            Thread.Sleep(4000);
            return 0;
        }
    }
}
