namespace HomeWork11
{
    internal class Program
    {
        static void Main()
        {
            var myCollection = new CustomCollection<int>();
            myCollection.Add(3);
            myCollection.Add(1);
            myCollection.Add(2);
            myCollection.Add(15);
            myCollection.Add(-1);

            Console.WriteLine("Original Collection:");
            foreach (var item in myCollection)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nCount: " + myCollection.Count);

            myCollection.Sort(new Comparator());
            Console.WriteLine("\nSorted Collection:");
            foreach (var item in myCollection)
            {
                Console.Write(item + " ");
            }

            myCollection.SetDefaultAt(1, 99);
            Console.WriteLine("\nAfter SetDefaultAt(1, 99):");
            foreach (var item in myCollection)
            {
                Console.Write(item + " ");
            }
        }
    }
}
