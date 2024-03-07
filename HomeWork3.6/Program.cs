namespace HomeWork3._6;

internal class Program
{
    static void Main(string[] args)
    {
        MessageBox messageBox = new MessageBox();
        messageBox.WindowClosed += (sender, state) => { HandleState(state); };

        Task task = messageBox.Open();
        task.Wait();
    }

    private static void HandleState(State state)
    {
        if (state == State.Ok)
        {
            Console.WriteLine("The operation has been confirmed.");
        }
        else
        {
            Console.WriteLine("The operation was rejected.");
        }
    }
}