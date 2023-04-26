using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rytirskacestabojohrad
{
    internal class rytir:bytost
    {
        private int sila = 54;
        public string jmeno = "Rytíř";
        public override int Pozdrav()
        {
            Console.WriteLine("{0}: Síla s tebou cizinče", jmeno);
            return 0;
        }
        /*
         Rytíři: Jakou taktiku na něj chceme použít?
            Hodit přes draka síť a tím znemožnit drakovi jakýkoliv pohyb. (tato taktika je správná)80% na vítězství
            Obklíčit ho a házet po něm oštěpy. (dračí kůži oštěpy neprorazí)30% na vítězství
            Počkat až usne a překvapit ho. (zemřete protože drak spánek jen předstírá) 10% na vítězství

        */
        public override int PataCast()
        {

            return 0;
        }
    }
}
