using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rytirskacestabojohrad
{
    internal class hospodsky:bytost
    {
        public string jmeno = "Hospodský";
        public override int CtvrtaCast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Co si vzácní pánové nabídnou?", jmeno);
            /*v
            Až do noci jste chlastali a hráli karty. (-100zł)
            Jenom jste se dobře najedli a šli jste spát. (-30zł)
            Ještě večer jste se zlili jak prasata a užili si noc s místními prostitutkami. (-128)
            */
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("1. Všichni jste si dali rundu piva a šli jste spát. (-50zł)");
            Thread.Sleep(1500);
            Console.WriteLine("2. Až do noci jste chlastali a hráli karty. (-100zł)");
            Thread.Sleep(1500);
            Console.WriteLine("3. Jenom jste se dobře najedli a šli jste spát. (-30zł)");
            Thread.Sleep(1500);
            Console.WriteLine("4. Ještě večer jste se zlili jak prasata a užili si noc s místními prostitutkami. (-128)");
            Thread.Sleep(1500);
            return 0;
        }
        public override int PataCast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Co si vzácní pánové nabídnou?", jmeno);
            /*v
            Až do noci jste chlastali a hráli karty. (-100zł)
            Jenom jste se dobře najedli a šli jste spát. (-30zł)
            Ještě večer jste se zlili jak prasata a užili si noc s místními prostitutkami. (-128)
            */
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Všichni jste si dali rundu piva a šli jste spát. (-50zł)");
            Thread.Sleep(1500);
            Console.WriteLine("2. Až do noci jste chlastali a hráli karty. (-100zł)");
            Thread.Sleep(1500);
            Console.WriteLine("3. Jenom jste se dobře najedli a šli jste spát. (-30zł)");
            Thread.Sleep(1500);
            Console.WriteLine("4. Ještě večer jste se zlili jak prasata a užili si noc s místními prostitutkami. (-128)");
            Thread.Sleep(1500);
            return 0;
        }
    }
}
