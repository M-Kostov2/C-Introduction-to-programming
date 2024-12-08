using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace File_Explorer
{
    public class FileOperations
    {
        //This class gives file operation methods

        public void ShowContent()
        {
            string path =  Environment.CurrentDirectory;
            
                
            string[] content = Directory.GetFiles(path);
            string[] Directories = Directory.GetDirectories(path);
            string[] AllContent = content.Concat(Directories).ToArray();
            
            foreach (string con in AllContent)
            {
                Console.WriteLine(con);
            }
        }

        //Check if file exist
        public bool FileExist(string filePath,string name)
        {
            bool exist = Directory.Exists(Path.Combine(filePath,name));
            Console.WriteLine(exist);
            return exist;
        }
        
        //Creates new directory(folder) 
        public void CreateNewDirectory(string directoryPath, string name)//c:/files
        {
            bool validator = FilePathProtection(directoryPath);
            if (validator == true)
            {
              Directory.CreateDirectory(Path.Combine(directoryPath, name));
              Console.WriteLine("Directory Created!");
              
            }
            else if (validator == false)
            {
                Console.WriteLine("No Access!");
            }

          
        }

        //Creates file
        public void CreateNewFile(string filePath, string name)
        {
            bool validator = FilePathProtection(filePath);
            if (validator == true)
            {
               File.Create(Path.Combine(filePath, name));
               Console.WriteLine("File Created!");        
              
            }
            else if (validator == false)
            {
                Console.WriteLine("No Access!");
            }

           
        }
         //Deletes file
        public void DeleteFile(string path,string typeDeletion)
        {
             bool validator = FilePathProtection(path);
             if (validator == true)
             {

                 if(typeDeletion == " Delete File")
                 {
                     File.Delete(path);  
                 }
                 else if (typeDeletion == "Delete Directory")
                 {
                     Directory.Delete(path);
                 }
             }
             else if (validator == false)
             {
                 Console.WriteLine("No Access!");
             }


        }
        //Sets Directory
        public void SetDirectory()
        {
            string path = Console.ReadLine();
            Directory.SetCurrentDirectory(path);
            Console.WriteLine($"Directory set: {path}");
        }

        //System Protection
        private bool FilePathProtection(string path)
        {   //do not add "!" it can cause serious consequences
            bool validation = (path == @"C:\Program Files" || 
                                path == @"C:\Program Files (x86)" || 
                                path == @"C:\PerfLogs" || 
                                path == @"C:\Users" || 
                                path == @"C:\Windows");

            return validation;

        }

        //Path reader
        //separates path and name from Original path and returns them as array
        public string[] PathReader()
        {
            string name = "";
            string path = "";
            string OriginalText = Console.ReadLine();
            string[] arr = OriginalText.Split(@"\");
            name = arr[arr.Length - 1];
            path = OriginalText.Remove(Math.Abs(arr[arr.Length-1].Length - OriginalText.Length));
            string[] arrOutput = new string[2];
            arrOutput[0] = path;
            arrOutput[1] = name;
            return arrOutput;

        }

        //Options
        public void ExplorerOptions()
        {
            Console.WriteLine("1.Show Content");
            Console.WriteLine("2.Create Directory");
            Console.WriteLine("3.Create File");
            Console.WriteLine("4.Delete Directory/File");
            Console.WriteLine("5.Set Directory");
            Console.WriteLine("6.Directory/File Exist");
            Console.WriteLine("7.Return to start");
            Console.WriteLine("8.Exit");
        }

    }
}
