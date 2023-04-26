using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rytirskacestabojohrad
{
    internal class Program:bytost
    {
        static void Main(string[] args)
        {

            //postavy
            rytir rytir = new rytir();
            vypravec vypravec = new vypravec();
            kral kral = new kral();
            banditi banditi = new banditi();
            hospodsky hospodsky = new hospodsky();


            //tutorial
           /* vypravec.Tutorial();

            //děj 
            vypravec.uvod();          
            kral.uvod();

             string input = Console.ReadLine();

                 if (input.ToLower() == "1")
                 {
                     Console.Clear();
                     Console.WriteLine("Ano, my to zvládneme.");
                 Thread.Sleep(2000);
                     kral.DruhaCast();

                 }
                 else if (input.ToLower() == "2")
                 {
                     Console.Clear();
                     Console.WriteLine("Ne, to nedokážeme.");
                     vypravec.Vypaleni();
                     vypravec.HodKostkou();

                 }
                 else
                 {
                     Console.WriteLine("Neplatná volba.");

                 }
             

            vypravec.DruhaCast();
            vypravec.TretiCast();
            banditi.TretiCast();

                string input1 = Console.ReadLine();
                if (input1.ToLower() == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("loupežníci je jednoduše zabili");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    vypravec.HodKostkou();

                }
                else if (input1.ToLower() == "2")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("rytíři přemůžou všechny loupežníky");
                    Thread.Sleep(2000);
                   

                }
                else
                {
                Console.WriteLine("Neplatna volba");
                    
                }
            */
            vypravec.CtvrtaCast();
            hospodsky.CtvrtaCast();
            string input2 = Console.ReadLine();
            if (input2.ToLower() == "1")
            {
                Console.Clear();
                Console.WriteLine("Vybral jsis: ");
                vypravec.PenizeMinus50();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Všichni jste si dali rundu piva a šli jste spát.");
                Thread.Sleep(3000);
                
            }
            else if (input2.ToLower() == "2")
            {
                Console.Clear();
                vypravec.PenizeMinus100();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Až do noci jste chlastali a hráli karty");
                Thread.Sleep(3000);


            }
            else if (input2.ToLower() == "3")
            {
                Console.Clear();
                vypravec.PenizeMinus30();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jenom jste se dobře najedli a šli jste spát.");
                Thread.Sleep(3000);


            }
            else if (input2.ToLower() == "4")
            {
                Console.Clear();
                vypravec.PenizeMinus128();
                Console.WriteLine("Vybral jsis: ");
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ještě večer jste se zlili jak prasata a užili si noc s místními prostitutkami");
                Thread.Sleep(3000);


            }
            else
            {
                Console.WriteLine("Neplatna volba");


            }
            vypravec.PataCast();



                Console.ReadKey();
           
        }
    }
}
