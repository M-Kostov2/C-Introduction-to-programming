using System.Text;
using System.Threading.Tasks.Dataflow;

namespace reading_and_writing_in_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Enter path to file.Like this (..\..\..\..\name of the file)");

            //string path = Console.ReadLine();
            string path = @"..\..\..\..\test.txt";
            

             StreamReader sReader = new StreamReader(path);

             

             string text = sReader.ReadToEnd();       
             string[] senteces = text.Split(new char[3] {'.', '!', '?' });
             string[] words = text.Split(new char[4] {' ','.','!','?'});

             sReader = new StreamReader(path);
             string line1 = sReader.ReadLine();
             string line2 = sReader.ReadLine();
             string line3 = sReader.ReadLine();

            
            FileStream file = File.Create(@"..\..\..\..\test2.txt");
            file.Close();
         
            File.AppendAllText(@"..\..\..\..\test2.txt",$"Sentences count{senteces.Length - 1}");            
            file.Close();
        
            File.AppendAllText(@"..\..\..\..\test2.txt",$"Words count{words.Length - 1}");            
            file.Close();
            
            File.AppendAllText(@"..\..\..\..\test2.txt",$"{String.Join(".",line1,line2,line3)}");
            file.Close();
            
            
           
           
        }
    }
}
