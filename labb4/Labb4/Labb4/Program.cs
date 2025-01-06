using System.IO.Pipes;
using System.Threading.Channels;

namespace Labb4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //hej 
            
                
            
            var person = new Person();
            /*Hair PersonHair  = new Hair();*/

            person.EyesColor = "blue ";
            person.Name = "jens";
            person.BirthDate = DateTime.Now;
            person.Gender=Gender.Male;
            person.Info = new Hair { Color = "Brown", Length = "10 m" };



            

            List<Person> People= new List<Person>();
            Boolean KeepGoing = true;
            while (KeepGoing)
            {
                
            }

             People.Add(new Person
             {

             });
            
                

            



            Console.WriteLine(person.ToString());
            Console.WriteLine($"Hair Color: {person.Info.Color}");
            Console.WriteLine($"Hair Style: {person.Info.Length}");
            Console.WriteLine(person.EyesColor + person.Name);
            Console.WriteLine(person.BirthDate);
            Console.WriteLine(person.Gender);












        }
        

       


       

                



        
    }
}
