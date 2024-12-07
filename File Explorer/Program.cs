using static File_Explorer.FileOperations;
using System.IO;

namespace File_Explorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get info 
            //проверка на дир дали съществува ако не нова папка
            //добавяме нови папки с числата от месеците
            //първата папка да има папка -01 (10файла) не повече ако не нова папка -02
            //взависимост от месеца



            // changing directory based on input then importing methods to work with the program 
            //implementing while cycle (end when you choose exit till then program circles in if else stastments)
            FileOperations directory = new FileOperations();
            Stack<string> Paths = new Stack<string>();
            string OriginalDirectory = "C:/";

            string command = "";



            Console.WriteLine("File Explorer");
            directory.ExplorerOptions();
            command = Console.ReadLine();
            Environment.CurrentDirectory = (OriginalDirectory);

            while (command != "Exit")
            {





                if (check)
                {
                    //newdir
                    //newDir//01//1-01


                }
                else if (message == "Folder doesn't exist")
                {
                    directory.NewDir();
                }







            }






        }
    }
}
