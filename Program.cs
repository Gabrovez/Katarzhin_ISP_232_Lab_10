namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog { Name = "Bobi" };
            Cat cat = new Cat { Name = "Smokey"};
            dog.Info();
            dog.MakeSound();
            cat.Info();
            cat.MakeSound();



        }
    }
}
