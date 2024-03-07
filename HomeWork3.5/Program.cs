namespace HomeWork3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string concatenatedText = program.ConcatenateTextAsync().Result;
            Console.WriteLine(concatenatedText);
        }
        
        async Task<string> ConcatenateTextAsync()
        {
            Task<string> helloTask = ReadFromHelloFileAsync();
            Task<string> worldTask = ReadFromWorldFileAsync();

            await Task.WhenAll(helloTask, worldTask);

            return helloTask.Result + " " + worldTask.Result;
        }
        async Task<string> ReadFromHelloFileAsync()
        {
            using (StreamReader reader = new StreamReader("Hello.txt"))
            {
                return await reader.ReadToEndAsync();
            }
        }
        
        async Task<string> ReadFromWorldFileAsync()
        {
            using (StreamReader reader = new StreamReader("World.txt"))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}