namespace Labb4
{

   public enum Gender
    {
        Male,             
        Female,         
        Nonbinary,      

    }

    public struct Hair()
    {
        public string Color { get; set; }
        public string Length;

    }
    public class Person
    {
        public string Name { get; set; }
        public string EyesColor;
        public Hair Info { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }


        
        public override string ToString()
        {
            return $"Ögonfärg {EyesColor}, Ålder {BirthDate}, name {Name}, kön {Gender}";
        }
    }
}