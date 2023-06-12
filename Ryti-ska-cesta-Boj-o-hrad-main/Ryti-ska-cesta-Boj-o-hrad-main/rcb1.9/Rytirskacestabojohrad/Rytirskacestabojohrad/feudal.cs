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
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}: Tak a je po něm.", jmeno);
            Thread.Sleep(1500);
            return 0;
        }
        // Co po nás žádáš Králi?
        public override int TretiCast()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}: Co po nás žádáš Králi?", jmeno);
            Thread.Sleep(2000);
            return 0;
        }
        //Feudál: Milí rytíři, vím, že Sir Aric z Železného pláště a  Sir Cedric ze Zlatého štítu byli vaši přátelé.
        //Byli to i mí přátelé a obětovali se pro nás a my to nesmíme vzdát.
        //Nyní víme, že je vede velmi dobrý taktik Tunelátor Sombra a na něho budeme potřebovat nějakou pomoc.
        //Proto se Sir Roland z Krvavého meče vydá na dlouhou a únavou cestu k mocnému čaroději Archibaldu Temnoveskému, který nám snad pomůže.

        public override int CtvrtaCast()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}: Milí rytíři, vím, že Sir Aric z Železného pláště a  Sir Cedric ze Zlatého štítu byli vaši přátelé.", jmeno);
            Thread.Sleep(3000);
            Console.WriteLine("{0}: Byli to i mí přátelé a obětovali se pro nás a my to nesmíme vzdát.", jmeno);
            Thread.Sleep(2000);
            Console.WriteLine("{0}: Nyní víme, že je vede velmi dobrý taktik Tunelátor Sombra a na něho budeme potřebovat nějakou pomoc.", jmeno);
            Thread.Sleep(3000);
            Console.WriteLine("{0}: Proto se Sir Roland z Krvavého meče vydá na dlouhou a únavou cestu k mocnému čaroději Archibaldu Temnoveskému, který nám snad pomůže.", jmeno);
            Thread.Sleep(4000);
            return 0;
        }




    }
}
