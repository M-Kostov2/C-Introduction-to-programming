namespace homework_2___social_platform_likes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name ="";
            int count = 0;
            string[] names = new string[2];
            
            
            while (true)
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();

                if (name =="")
                {                 
                    continue;                                  
                }
                if(count < 2 )
                {
                    names[count] = name;
                    count++;
                    if (count == 1)
                    {
                        Console.WriteLine($"{names[0]} liked your post");
                        continue;
                    }
                    if (count == 2)
                    {
                        Console.WriteLine($"{names[0]} and {names[1]} liked your post");
                        continue;
                    }

                }
               
                Console.WriteLine($"{names[0]}, {names[1]} and {count-1} liked your post");
                count++;


            }
        }
    }
}
