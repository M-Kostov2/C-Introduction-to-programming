namespace writing_in_csv_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileStream file = File.Create(@"file.csv");

            StreamReader sr = new StreamReader(@"file.csv");
            List<int> MaxPrice = new List<int>();
            double quantity = 0;
            string mostSold = "";
            while (sr.EndOfStream == false)
            {
                string[] line = sr.ReadLine().Split("/");
                Console.WriteLine($"Product {line[0]}");
                double price = (double.Parse(line[1]) * double.Parse(line[2]));
                Console.WriteLine($"Quantity * Price = {price:f2}");
                MaxPrice.Add(int.Parse(line[2]));
                
                if (double.Parse(line[2]) > quantity)
                {
                    quantity = double.Parse(line[2]);
                    mostSold = line[0];
                }
                
            }
            sr.Close();
            Console.WriteLine($"Most sold product: {mostSold} quantity-{quantity}");
        }
    }
}
