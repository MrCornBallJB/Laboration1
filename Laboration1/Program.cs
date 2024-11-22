using System.Diagnostics.SymbolStore;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Laboration1
{
    internal class Program
    {

        
        static void Main(string[] args)
        {

            //Array med flygsresorna
            string[] flyg = { "Stockhom - New York", "New York - Stockholm" };

            //Början av interface
            Console.WriteLine("******************************************");
            Console.WriteLine();
            Console.WriteLine("Välkommen till flygtidsberäknaren!");
            Console.WriteLine();
            Console.WriteLine("Vilken resa vill du se detaljerad information om? (Svara med siffror)");

            while (true)
            {
                
                int avslut = 0;

                
                //For-loop som går igenom arrayen för att läsa upp interfacen
                for (int i = 0; i < flyg.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + flyg[i]);
                    avslut++;
                }
                Console.WriteLine((avslut+1) + ": Avsluta proggrammet");

                //Början av userinputs
                Console.Write("Skriv ditt val här: ");
                int svar = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //Switchcases som läser användarens svar
                switch (svar)
                {
                    case 1:
                        //fakta om Stockholm - New York
                        svar1(flyg[0]);
                        break;

                    case 2:
                        //fakta om New York - Stockholm
                        svar2(flyg[1]);
                        break;

                    case 3:
                        exit();
                        break;
                }
                if (svar != 1 && svar != 2 && svar != 3)
                {
                    Console.WriteLine("Fel input!");
                }
                Console.WriteLine();
            }


        }
        static void svar1(string flyg) 
        {
            //Avgångstiden
            int avgtimmar = 14;
            int avgminuter = 3;

            //Flygsträckan
            int flygtimmar = 7;
            int flygminuter = 25;

            int tidsskillnad = 6;

            //Adderar avgångstiderna och flygsträckan och sätter de i en string för att göra så att det kan bli "00"
            string fulltimmar = (avgtimmar + flygtimmar - tidsskillnad).ToString("00");
            string fullminuter = (avgminuter + flygminuter).ToString("00");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Avågnstiden för " +flyg + " " + avgtimmar.ToString("00")+":" + avgminuter.ToString("00"));
            Console.WriteLine("landningstid för Stockholm till NewYork: " + fulltimmar + ":" + fullminuter);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            //test commit


        }
        static void svar2(string flyg) 
        {
            //Avgångstiden
            int avgtimmar = 10;
            int avgminuter = 10;

            //Flygsträckan
            int flygtimmar = 7;
            int flygminuter = 25;

            int tidsskillnad = 6;

            //Adderar avgångstiderna och flygsträckan och sätter de i en string för att göra så att det kan bli "00"
            string fulltimmar = (avgtimmar + flygtimmar + tidsskillnad).ToString("00");
            string fullminuter = (avgminuter + flygminuter).ToString("00");

            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Avågnstiden för " + flyg + " " + avgtimmar.ToString("00") + ":" + avgminuter.ToString("00"));
            Console.WriteLine("landningstid för " + flyg + " " + fulltimmar + ":" + fullminuter);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********************************************************************");
            Console.WriteLine();
            Console.WriteLine();

        }
        static void exit() 
        {
            Environment.Exit(0);
            
        }
    }
}
