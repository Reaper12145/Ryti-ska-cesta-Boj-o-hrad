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
            Thread.Sleep(2500);
            Console.WriteLine("{0}: To je moje království!!!!!!!!!", jmeno);
            Thread.Sleep(2500);
            Console.WriteLine("{0}: Puste mně!!!!!!!!!!!!", jmeno);
            Thread.Sleep(2500);
            Console.WriteLine("{0}: Puste mně nebo na vás pošlu Byrua!!!!!!!!", jmeno);
            Thread.Sleep(3000);

            return 0;
        }
        public override int TretiCast()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}: Ty jsi nevzpomínáš?", jmeno);
            Thread.Sleep(2000);
            Console.WriteLine("{0}: Před 20 lety jsi jel se svou družinou na lov a našli jste doupě s 5. dračími vejci", jmeno);
            Thread.Sleep(4000);
            Console.WriteLine("{0}: 4 vejce jste si dali ten den na večeři, ale v noci tam přiletěla dračice a celou svou družinu zabila.", jmeno);
            Thread.Sleep(4500);
            Console.WriteLine("{0}: Ty čtyři vejce byli mí sourozenci a já jsem je přišel pomstít.", jmeno);
            Thread.Sleep(4000);
            Console.Clear();
            return 0;
        }
    }
}
