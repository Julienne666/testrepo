namespace HomeWork3._3
{
    public class Program
    {
        public static void Show(bool result)
        {
            Console.WriteLine("Is divisible without remainder: " + result);
        }

        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();

            class1.ShowDelegate = Show;

            Func<int, bool> resultDelegate = class2.Calc(class1.Multiply, 10, 5);

            class1.ShowDelegate(resultDelegate(2)); 
        }
    }
}

public delegate void ShowDelegate(bool result);






