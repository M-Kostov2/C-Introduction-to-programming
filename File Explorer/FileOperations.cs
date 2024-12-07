using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace File_Explorer
{
    public class FileOperations
    {
        //This class gives file operation methods


        //Check if file exist
        public bool FileExist(string DirectoryPath,string Name)
        {
            bool exist = Directory.Exists(Path.Combine(DirectoryPath,Name));

            return exist;
        }

        //Creates new directory(folder) 
        public void CreateNewDirectory(string DirectoryPath, string Name)//c:/files
        {
            Directory.CreateDirectory(Path.Combine(DirectoryPath, Name));
            Console.WriteLine("Directory Created!");
        }

        //Creates file
        public void CreateNewFile(string DirectoryPath, string Name)
        { 
          File.Create(Path.Combine(DirectoryPath, Name));
          Console.WriteLine("File Created!");        
        }

        public void ExplorerOptions()
        {
            Console.WriteLine("1.Show Content");
            Console.WriteLine("2.Create Directory");
            Console.WriteLine("3.Create File");
            Console.WriteLine("4.Delete Directory/File");
            Console.WriteLine("5.Set Directory");
            Console.WriteLine("6.Directory/File Exist");
            Console.WriteLine("7.Exit");
        }

    }
}
