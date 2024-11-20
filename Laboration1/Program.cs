using System.Diagnostics.SymbolStore;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Laboration1
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            
            string[] flyg = { "Stockhom - New York", "New York - Stockholm" };

            //Början av interface
            Console.WriteLine("Välkommen till flygtidsberäknaren!");
            Console.WriteLine("Vilken resa vill du se detaljerad information om? Svara med nummer");

            while (true)
            {
                
                //For-loop som går igenom arrayen för att läsa upp interfacen
                for (int i = 0; i < flyg.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + flyg[i]);
                }
                Console.WriteLine("3: Avsluta proggrammet");

                //Början av userinputs
                int svar = int.Parse(Console.ReadLine());

                //Switchcases som läser användarens svar
                switch (svar)
                {
                    case 1:
                        //fakta om Stockholm - New York
                        svar1();
                        break;

                    case 2:
                        //fakta om Stockholm - New York
                        svar2();
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
        static void svar1() 
        {
            //Avgångstiden
            int avgtimmar = 14;
            int avgminuter = 3;

            //Flygsträckan
            int flygtimmar = 7;
            int flygminuter = 25;

            int tidsskillnad = 6;

            //
            Console.WriteLine("Avågnstiden från Stockhom - New York: " + avgtimmar.ToString("00")+":" + avgminuter.ToString("00"));

            //Adderar avgångstiderna och flygsträckan och sätter de i en string för att göra så att det kan bli "00"
            string fulltimmar = (avgtimmar + flygtimmar - tidsskillnad).ToString("00");
            string fullminuter = (avgminuter + flygminuter).ToString("00");

            Console.WriteLine("landningstid från Stockholm till NewYork: " + fulltimmar + ":" + fullminuter);

            




          

            



        }
        static void svar2() 
        {
            //Avgångstiden
            int avgtimmar = 10;
            int avgminuter = 10;

            //Flygsträckan
            int flygtimmar = 7;
            int flygminuter = 25;

            int tidsskillnad = 6;

            //Adderar avgångstiderna och flygsträckan och sätter de i en string för att göra så att det kan bli "00"
            Console.WriteLine("Avågnstiden från NewYork:" + avgtimmar.ToString("00") + ":" + avgminuter.ToString("00"));
            string fulltimmar = (avgtimmar + flygtimmar + tidsskillnad).ToString("00");
            string fullminuter = (avgminuter + flygminuter).ToString("00");

            Console.WriteLine("landningstid från NewYork till Stockholm: " + fulltimmar + ":" + fullminuter);

        }
        static void exit() 
        {
            Environment.Exit(0);
            
        }
    }
}
