namespace exersice_1_file_stream
{
    internal class Program
    {
        static void Main(string[] args)
        {   //1exersice

            string path = "C://UnivercityC#//..//textdocument11.txt";
            bool file =  File.Exists(path);
            Console.WriteLine(file);


        }
    }
}
