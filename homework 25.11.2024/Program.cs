namespace homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string> ();
            Console.WriteLine("Write number of people");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Write {n} names");
            for (int i = 0; i < n; i++)
            {
                names.Enqueue(Console.ReadLine());
            }
            while (names.Count != 0)
            {    Console.WriteLine($"Serving: {names.Dequeue()}");
                if (names.Count != 0)
                {                    
                    Console.WriteLine($"Next in Line: {names.Peek()}");
                    continue;
                }
               
            }
        }
    }
}
