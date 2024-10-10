namespace DIPratik.Models
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public void GetTeacherInfo()
        {
            Console.WriteLine("Merhaba Çocuklar, Ders Başlıyor.");
            _teacher.GetInfo();

        }

    }
}
