using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rytirskacestabojohrad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //postavy
            rytir rytir = new rytir();
            vypravec vypravec = new vypravec();

            kral kral = new kral();
            //děj
            Console.ForegroundColor = ConsoleColor.Green;
            vypravec.uvod();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            kral.uvod();

            string input = Console.ReadLine();

            if (input.ToLower() == "a")
            {
                Console.WriteLine("Přijmout nabidku");
                // kód pro pokračování levou cestou
            }
            else if (input.ToLower() == "n")
            {
                Console.WriteLine("Odmitnout nabidku");
                // kód pro pokračování pravou cestou
            }
            else
            {
                Console.WriteLine("Neplatná volba.");
            }





            //děj
            Console.ForegroundColor = ConsoleColor.Green;
            vypravec.uvod();
            Console.Clear();
            
            Console.ForegroundColor= ConsoleColor.Yellow;
            kral.uvod();


            Console.ReadKey();
        }
    }
}
