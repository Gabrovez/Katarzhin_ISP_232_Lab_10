namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        // Я когда альтабался поменять музыку забыл потом снять с паузы
        //Надеюсь что простите, тут ничего такого сложного не было просто структуры из лабы писал и всё
        // Тут и так всё что я написал за это время видно что писал сам по времени коммитов, буду повнимательнее вредь
        static void Main(string[] args)
        {
            foreach (int number in GenerateNumbers())
            {
                Console.WriteLine($"Number received: {number}");
            }
        }
        static IEnumerable<int> GenerateNumbers()
        {
            Console.WriteLine("Starting generation...");
            yield return 1;

            Console.WriteLine("Pause...");
            yield return 2;

            Console.WriteLine("And one more time...");
            yield return 3;

            Console.WriteLine("Done!");
        }
        



        //static void Main(string[] args)
    }
}
