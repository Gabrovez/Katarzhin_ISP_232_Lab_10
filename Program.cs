namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Grisha";
            student.University = "VF VolGU";
            student.SayHello();
            Console.WriteLine($"Studying in: {student.University}");


        }
    }
}
