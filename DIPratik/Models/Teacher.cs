namespace DIPratik.Models
{
    public class Teacher:ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("Adım "+FirstName+" "+LastName+", bu sınıfın öğretmeni benim.");
        }
    }
}
