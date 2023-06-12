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
       /*
         Rytíři: Jakou taktiku na něj chceme použít?


        */
        public override int PataCast()
        {
            Console.WriteLine("{0}: Jakou taktiku na něj chceme použít?", jmeno);
            return 0;
        }
    }
}
