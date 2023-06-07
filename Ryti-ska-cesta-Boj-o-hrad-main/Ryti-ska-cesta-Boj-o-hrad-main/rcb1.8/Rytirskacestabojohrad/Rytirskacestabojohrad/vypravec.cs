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
        public string zustatek = "penize";
        //Console.ForegroundColor = ConsoleColor.Cyan;

        public override int Tutorial()
        {            
            Console.WriteLine("Vítej v naší hře. Tato hra je postavena na tvých rozhodnutích. Jakmile si vybereš špatnou možnost, tak můžeš zemřít a budeš muset jít od znova. Ale je zde možnost hodu kostkou, kterou se budeš moct oživit. Přejeme ti málo smrtí a hodně zdaru.");
            Thread.Sleep(6000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            Console.WriteLine("Pro pokračovani zmačkni libovolnou klavesu");
            Console.ReadKey();
            Console.Clear();
            return 0;
        }


        public override int uvod()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Vysoko v horách leží tajemný hrad, který byl kdysi sídlem mocného krále.", jmeno);
            Thread.Sleep(6000);
            Console.WriteLine("{0}: Jeho poddaní mu sloužili s oddaností, ale když se na obzoru objevil drak, jejich životy se změnily.", jmeno);
            Thread.Sleep(6500);
            Console.WriteLine("{0}: Drak vybíral výpalné a ničil vesnice.", jmeno);
            Thread.Sleep(3000);
            Console.Clear();
            return 0;
        }


        public override int Vypaleni()
            {

            Console.WriteLine("Hrozný drak dále tyranizoval hrad a poddané ");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            return 0;
            }


        public override int HodKostkou()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hoď si s kostkou pokud ti padne 6 mužeš pokračovat v přiběhu pokud spadne meně hra se vypne");
            Thread.Sleep(2000);
            Console.WriteLine("hodiš zmačknuti klavesy");
            Console.ReadKey();

            Random rand = new Random();
            int randomNumber = rand.Next(1, 7);
            Console.WriteLine("Hodnota kostky: " + randomNumber);
            Thread.Sleep(3000);


            if (randomNumber == 6)
            {
                Vraceni();
            }
            if (randomNumber < 6)
            {
                Console.Clear();
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀\r\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼\r\n██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀\r\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼\r\n███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼\r\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼\r\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼\r\n██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼\r\n███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (randomNumber == 2)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ%22");
                Console.Clear();
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀\r\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼\r\n██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀\r\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼\r\n███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼\r\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼\r\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼\r\n██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼\r\n███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return 0;
        }


        public override int Vraceni()
        {
            Console.WriteLine("byl jsi vracen!");
            uvod();
            return 0;
        }


        public override int DruhaCast()
        {

            Console.WriteLine("Aktualni zustatek: {0}", penize);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Feudál se svýma rytířema se vydal na dlouhou cestu k drakovi.", jmeno);
            Thread.Sleep(4000);
            return 0;
        }


        public override int TretiCast()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Cestou je napadla banda loupežníků.", jmeno);
            Console.Clear();
            return 0;

        }


        public override int HodKostkoub()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hoď si s kostkou pokud ti padne 6 mužeš pokračovat v přiběhu pokud spadne meně hra se vypne");
            Thread.Sleep(2000);
            Console.WriteLine("hodiš zmačknuti klavesy");
            Console.ReadKey();

            Random rand = new Random();
            int randomNumber = rand.Next(1, 7);
            Console.WriteLine("Hodnota kostky: " + randomNumber);
            Thread.Sleep(3000);


            if (randomNumber == 6)
            {
                Vracenii();
            }
            if (randomNumber < 6)
            {
                Console.Clear();
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀\r\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼\r\n██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀\r\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼\r\n███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼\r\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼\r\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼\r\n██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼\r\n███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (randomNumber == 2)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ%22");
                Console.Clear();
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀\r\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼\r\n██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀\r\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼\r\n███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼\r\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼\r\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼\r\n██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼\r\n███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return 0;
        }


        public override int Vracenii()
        {
            Console.WriteLine("byl jsi vracen!");
            TretiCast();
            return 0;
        }


        public override int CtvrtaCast()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Za odměnu jste si zašli do hospody.", jmeno);
            Thread.Sleep(2000);


            return 0;
        }


        public override int PenizeMinus50()
        {
            penize = -50;
            return penize;
        }


        public override int PenizeMinus100()
        {
            penize = -100;
            return penize;
        }


        public override int PenizeMinus30()
        {
            penize = -30;
            return penize;
        }


        public override int PenizeMinus128()
        {
            penize = -128;
            return penize;
        }


        public override int PataCast()
        {
            Console.Clear();
            Console.WriteLine("Aktualni zustatek: {0}", penize);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Po dlouhé a únavné cestě jste přišli k dračí sluji.", jmeno);
            Thread.Sleep(2000);
            return 0;
        }


        public override int SestaCast()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Draka se jim povedlo zajmout.", jmeno);
            Thread.Sleep(2000);
            return 0;
        }


        public override int SedmaCast()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Feudal se svými rytíři přivede draka před krále", jmeno);
            Thread.Sleep(4000);
            Console.Clear();
            return 0;
        }
        public override int OsmaCast()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Feudál se svými rytíři si žil spokojený život, než se v podzemí zrodil nápad na ovládnutí celého království. ",jmeno);
            Thread.Sleep(4000);
            return 0;
        }
        //Vypravěč: Feudál s rytíři tentokrát na cestu dostali od krále 500 zł. A vydali se na cestu do podzemí, ale cestoou se zase stavili do hospody.

        public override int DevataCast()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Feudál s rytíři tentokrát na cestu dostali od krále 500 zł. A vydali se na cestu do podzemí, ale cestoou se zase stavili do hospody. ",jmeno);
            Thread.Sleep(4000);
            PenizePlus500();
            Console.WriteLine("Aktualni zustatek: {0}", penize);
            return 0;
        }

        //Vypravěč: Feudál společně se svými rytíři se usídlil nedalo vesnice jménem Šumivá Zátoka. To se však dozvěděly stvůry z podzemí s vůdcem Tunelátor Sombra, který se rozhodl rytíře v noci napadnout.

        public override int DesataCast()
        {
            Console.Clear();

            Console.WriteLine("Aktualni zustatek: {0}",penize);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Feudál společně se svými rytíři se usídlil nedalo vesnice jménem Šumivá Zátoka. ", jmeno);
            Console.WriteLine("{0}: To se však dozvěděly stvůry z podzemí s vůdcem Tunelátor Sombra, který se rozhodl rytíře v noci napadnout.", jmeno);
            Thread.Sleep(4000);

            return 0;
        }
    }
}
