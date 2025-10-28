namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        // Я когда альтабался поменять музыку забыл потом снять с паузы
        //Надеюсь что простите, тут ничего такого сложного не было просто структуры из лабы писал и всё
        // Тут и так всё что я написал за это время видно что писал сам по времени коммитов, буду повнимательнее вредь
        static void Main(string[] args)
        {
            List<ISound> sounds = new List<ISound>
            {
                new Bird(),
                new Phone()
            };
            foreach (var sound in sounds)
            {
                sound.MakeSound();
            }

            Book book = new Book {Name = "War and peace" };
            Console.WriteLine(book.Name);
            Duck duck = new Duck();
            ((IFlier)duck).Fly();
            ((ISwimer)duck).Swim();
        }
    }
}
