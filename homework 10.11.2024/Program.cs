namespace homework_10._11._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            string side = Console.ReadLine();


            if (side == "left")
            {
               //declaring variables
                string blanks = "";
                string ast = "";
                //writing first *
                Console.Write($"{ast}{blanks}*");
                Console.WriteLine();

                //writing all others
                for (int i = 1; i < h - 1; i++)
                {
                    ast = "*";
                    Console.Write($"{ast}{blanks}*");
                    Console.WriteLine();
                    
                    blanks += " ";

                }

                //writing last line
                ast = "";
                for (int i = 0; i < h; i++)
                {
                    ast += "*";
                }
                Console.WriteLine(ast);
            }
            else if(side=="right")
            {   
                //declaring variabels
                string blanks = "";
                string ast = ""; 
                string blanks2 ="";

                //making blanks(blank space less with 1)
                for (int i = 0; i < h-1; i++)
                {
                    blanks +=" ";
                }
               

                int temp = h;
                
               //printing first *
                Console.Write($"{blanks}{ast}*");
                Console.WriteLine();

                //printing all others
                for (int i = 1; i < h-1; i++)
                {   ast = "*";
                     blanks = "";
                    for (int k = temp-1; k > 1; k--)
                    {
                        
                        blanks +=" ";
                        
                    }
                     temp--;  
                    //these 2 are just for debuging for seeing values in real time
                    string nn = $"{blanks}{ast}{blanks2}*";
                    int len = blanks.Length;
                    //---------------------

                    //printing next line----
                    Console.Write($"{blanks}{ast}{blanks2}*");
                    Console.WriteLine();
                    
                                    
                    //growing the space between *       
                    blanks2 +=" ";
                
                }
                ast = "";
                for (int i = 0; i < h; i++)
                {
                    ast += "*";
                }
                Console.WriteLine(ast);
                


                
            }
          
        }
        //
    }
}
