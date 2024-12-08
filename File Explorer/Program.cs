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



            // 
            //implementing while cycle (end when you choose exit till then program circles in if else statements)
            FileOperations directory = new FileOperations();
           
            string OriginalDirectory = "C:/";

            string command = "";



            Console.WriteLine("File Explorer");
            directory.ExplorerOptions();
            command = Console.ReadLine();
            Environment.CurrentDirectory = (OriginalDirectory);

            while (command != "Exit")
            {
                if(command=="Show Content")
                {
                    directory.ShowContent();
                }
                else if (command =="Create Directory")
                {
                    Console.WriteLine("Enter path and name:");
                    string[] parameters = directory.PathReader();
                    directory.CreateNewDirectory(parameters[0], parameters[1]);
                }
                else if (command =="Create File")
                {
                    Console.WriteLine("Enter path and name:");
                    string[] parameters = directory.PathReader();
                    directory.CreateNewFile(parameters[0], parameters[1]);
                }
                else if (command =="Delete Directory" || command =="Delete File")
                {
                    //add safety checks
                    Console.WriteLine("Enter path and name:");
                    string[] parameters = directory.PathReader();
                    directory.DeleteFile(parameters[0], parameters[1]);
                }
                else if (command =="Set Directory")
                {
                    Console.WriteLine("Enter path and name:");
                    directory.SetDirectory();
                }
                else if (command == "Directory Exist" || command =="File Exist")
                {
                    Console.WriteLine("Enter path and name:");
                    string[] parameters = directory.PathReader();
                    directory.FileExist(parameters[0], parameters[1]);
                }
                else if (command == "Return to start")
                {
                    Console.Clear();
                    directory.ExplorerOptions();

                }
                else if(command == "Exit")
                {
                    break;

                }

                Console.WriteLine();
                command = Console.ReadLine();

            }
            





        }
    }

    //"1.Show Content");
    //"2.Create Directory");
    //"3.Create File");
    //"4.Delete Directory/File");
    //"5.Set Directory");
    //"6.Directory/File Exist");
    //"7.Exit");
}
