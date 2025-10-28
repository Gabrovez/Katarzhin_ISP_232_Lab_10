namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Square(int x)
            {
                return x * x;
            }
            Console.WriteLine(Square(5));

            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));
            Button button = new Button();
            button.OnClick += () => Console.WriteLine("Buttom pressed!");
            button.Click();

        }
    }
    public class Button
    {
        public event Action OnClick;
        public void Click()
        {
            OnClick?.Invoke();
        }
    }
}
