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

            //pokemoni
            bool BilleDelphine = false;
            bool Amouranth = false;
            bool Bulbasaur = false;
            bool Eevee = false;
            bool Piplup = false;

            //postavy
            rytir rytir = new rytir();
            vypravec vypravec = new vypravec();
            kral kral = new kral();
            banditi banditi = new banditi();
            hospodsky hospodsky = new hospodsky();
            drak drak = new drak();
            feudal feudal = new feudal();

            
            //tutorial
            vypravec.Tutorial();

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


            rytir.PataCast();

            Console.WriteLine("1. Obklíčit ho a házet po něm oštěpy.");
            Console.WriteLine("2. Hodit přes draka síť a tím znemožnit drakovi jakýkoliv pohyb.");
            Console.WriteLine("3. Počkat až usne a překvapit ho");
            string input3 = Console.ReadLine();

            if (input3.ToLower() == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Obklíčit ho a házet po něm oštěpy.");
                Thread.Sleep(3000);
                vypravec.HodKostkou();

            }
            else if (input3.ToLower() == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hodit přes draka síť a tím znemožnit drakovi jakýkoliv pohyb.");
                Thread.Sleep(3000);
                Console.Clear();
                vypravec.SestaCast();


            }
            else if (input3.ToLower() == "3")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Počkat až usne a překvapit ho");
                Thread.Sleep(3000);
                vypravec.HodKostkou();

            }
            else
            

            drak.DruhaCast();


            vypravec.SedmaCast();


            kral.TretiCast();


            drak.TretiCast();


            kral.CtvrtaCast();


            string input4 = Console.ReadLine();
            if (input4.ToLower() == "1")
            {
                Console.Clear();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nechat zabít draka.");
                Thread.Sleep(3000);
                feudal.DruhaCast();

            }
            else if (input4.ToLower() == "2")
            {
                Console.Clear();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vyhnat draka z království");
                Thread.Sleep(2000);
                Console.WriteLine("drak se vrátí a už ho nikdo v plenění nezastaví");
                Thread.Sleep(3000);
                vypravec.HodKostkou();


            }

            else
            {
                Console.WriteLine("Neplatna volba");


            }
            

            kral.PataCast();


            string input5 = Console.ReadLine();
            if (input5.ToLower() == "1")
            {
                Console.Clear();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Xholakys.");               
                Thread.Sleep(3000);
                Console.WriteLine("Škoda zrovna ona tě utýrala k smrti.");
                vypravec.HodKostkou();

            }
            else if (input5.ToLower() == "2")
            {
                Console.Clear();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bille Delphine");
                BilleDelphine = true;
                Thread.Sleep(2000);
                Console.WriteLine("Užiješ si radostné chvíle.");
                Thread.Sleep(3000);
                //pokračování 2.čast


            }
            else if (input5.ToLower() == "3")
            {
                //Amouranth ( Užijete si radostné chvíle v sedle koní )
                Console.Clear();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Amouranth");
                Amouranth = true;
                Thread.Sleep(2000);
                Console.WriteLine("Užijete si radostné chvíle v sedle koní");
                Thread.Sleep(3000);
                //pokračování 2.část


            }
            else if (input5.ToLower() == "4")
            {
                //Pikachu ( zahrávat si s elektřinou není dobrý nápad )
                Console.Clear();
                System.Diagnostics.Process.Start("https://youtu.be/ZUgrRQCpRZE");
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pikachu");
                Thread.Sleep(2000);
                Console.WriteLine("zahrávat si s elektřinou není dobrý nápad");
                Thread.Sleep(3000);
                Console.WriteLine("omylem zapálil ve spánku barák");
                Console.ReadKey();
                vypravec.HodKostkou();


            }
            else if (input5.ToLower() == "5")
            {
                //Bulbasaur ( Bulbasaur se ti stará o tvou zahradu)
                Console.Clear();
                System.Diagnostics.Process.Start("https://youtu.be/ZUgrRQCpRZE");
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bulbasaur");
                Bulbasaur = true;
                Thread.Sleep(2000);
                Console.WriteLine("Bulbasaur se ti stará o tvou zahradu");
                Console.ReadKey();
                //pokračování 2.část


            }
            else if (input5.ToLower() == "6")
            {
                //Eevee ( Nejvěrnější a nejroztomilejšťější pokémon )
                Console.Clear();
                System.Diagnostics.Process.Start("https://youtu.be/ZUgrRQCpRZE");
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Eevee");
                Eevee = true;
                Thread.Sleep(2000);
                Console.WriteLine("Nejvěrnější a nejroztomilejšťější pokemon");
                Console.ReadKey();
                //druha cast


            }
            else if (input5.ToLower() == "7")
            {

                //Piplup ( pomáhá ti při plavbě)
                Console.Clear();
                System.Diagnostics.Process.Start("https://youtu.be/ZUgrRQCpRZE");
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Piplup");
                Piplup = true;
                Thread.Sleep(2000);
                Console.WriteLine("pomáhá ti při plavbě");
                Console.ReadKey();
                //druhacast


            }

            else
            {
                Console.WriteLine("Neplatna volba");


            }


            vypravec.OsmaCast();


            kral.SestaCast();


            feudal.TretiCast();

            
            kral.SedmaCast();


            string input6 = Console.ReadLine();
            if (input6.ToLower() == "1")
            {
                Console.Clear();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pomoct králi.");
                Thread.Sleep(3000);
                kral.OsmaCast();

            }
            else if (input6.ToLower() == "2")
            {
                Console.Clear();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nepomoct králi");
                Thread.Sleep(2000);
                Console.WriteLine("Vládce podzemí ovládne celé království a všechny rytíře postupně vyvraždí");
                Thread.Sleep(3000);
                vypravec.HodKostkou();


            }

            else
            {
                Console.WriteLine("Neplatna volba");

            }
            
            vypravec.DevataCast();


            hospodsky.PataCast();


            string input7 = Console.ReadLine();
            if (input7.ToLower() == "1")
            {
                Console.Clear();
                Console.WriteLine("Vybral jsis: ");
                vypravec.PenizeMinus50();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Všichni jste si dali rundu piva a šli jste spát.");
                Thread.Sleep(3000);
                vypravec.DesataCast();

            }
            else if (input7.ToLower() == "2")
            {
                Console.Clear();
                vypravec.PenizeMinus100();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Až do noci jste chlastali a hráli karty");
                Thread.Sleep(3000);
                vypravec.DesataCast();

            }
            else if (input7.ToLower() == "3")
            {
                Console.Clear();
                vypravec.PenizeMinus30();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jenom jste se dobře najedli a šli jste spát.");
                Thread.Sleep(3000);
                vypravec.DesataCast();

            }
            else if (input7.ToLower() == "4")
            {
                Console.Clear();
                vypravec.PenizeMinus128();
                Console.WriteLine("Vybral jsis: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ještě večer jste se zlili jak prasata a užili si noc s místními prostitutkami");
                Thread.Sleep(3000);
                vypravec.DesataCast();

            }
            else
            {
                Console.WriteLine("Neplatna volba");


            }
          







            Console.ReadKey();
           
        }
    }
}
