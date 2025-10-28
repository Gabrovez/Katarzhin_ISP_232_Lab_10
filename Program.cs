namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Grisha";
            student1.University = "VF VolGU";
            student1.SayHello();
            Console.WriteLine($"Studying in: {student1.University}");
            
            Student student2 = new Student();
            student2.Name = "Anton";
            student2.SayHello();

        }
    }
}
