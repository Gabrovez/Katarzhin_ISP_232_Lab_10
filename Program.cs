namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        // Я когда альтабался поменять музыку забыл потом снять с паузы
        //Надеюсь что простите, тут ничего такого сложного не было просто структуры из лабы писал и всё
        // Тут и так всё что я написал за это время видно что писал сам по времени коммитов, буду повнимательнее вредь
        static async Task Main()
        {
            Console.WriteLine("1. Turn on the kettle...");

            Task boilTask = BoilWateAsync();
            Task sliceTask = SliceLemonAsync();
            await Task.WhenAll(boilTask, sliceTask);
            Console.WriteLine("4. Let's brew a tea with the lemon!");
        }
        static async Task BoilWateAsync() {
            Console.WriteLine("2. Boil the water (wait for 3 sec)...");
            await Task.Delay(3000);
            Console.WriteLine("... water is boiled over!");
        }
        static async Task SliceLemonAsync()
        {
            Console.WriteLine("3. Slicing the lemon (wait for 2 sec)...");
            await Task.Delay(2000);
            Console.WriteLine("... lemon is sliced!");
        }



        //static void Main(string[] args)
    }
}
