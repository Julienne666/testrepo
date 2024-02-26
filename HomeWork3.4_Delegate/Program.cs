using System;

public class Program
{
    public delegate int CalculateDelegate(int num1, int num2);
    
    public event CalculateDelegate CalculationEvent;

    public int Calculate(int num1, int num2)
    {
        return num1 + num2;
    }

    public void Subscribe()
    {
        CalculationEvent += Calculate;
        CalculationEvent += Calculate;
    }

    public int CalculateSumWithTryCatch()
    {
        int sum = 0;
        TryCatch(() =>
        {
            sum = CalculateSum(CalculationEvent);
        });
        return sum;
    }

    private void TryCatch(Action action)
    {
        try
        {
            action.Invoke();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    private int CalculateSum(CalculateDelegate calcDelegate)
    {
        int sum = 0;

        if (calcDelegate != null)
        {
            sum = calcDelegate.Invoke(10, 5);
        }

        return sum;
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Subscribe();

        int resultSum = program.CalculateSumWithTryCatch();
        Console.WriteLine("Sum of calculation results: " + resultSum);
    }
}