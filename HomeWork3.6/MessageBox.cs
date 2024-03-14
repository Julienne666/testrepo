namespace HomeWork3._6;

public class MessageBox
{
    public event EventHandler<State> WindowClosed;
    public async Task Open()
    {
        Console.WriteLine("Window is open");
        await Task.Delay(3000); 
        Console.WriteLine("Window was closed by the user");
        WindowClosed(this, new Random().Next(2) == 0 ? State.Ok : State.Cancel);
    }
}