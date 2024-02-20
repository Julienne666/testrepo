namespace HomeWork3._3;

public class Class2
{
    private int multiplicationResult;

    public bool Result(int number)
    {
        return multiplicationResult % number == 0;
    }

    public Func<int, bool> Calc(Func<int, int, int> multiplyDelegate, int num1, int num2)
    {
        multiplicationResult = multiplyDelegate(num1, num2);

        return Result;
    }
}