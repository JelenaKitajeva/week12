using System;
using System.IO;
namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Choose the operation create, move or delete:");
            string type = Console.ReadLine().ToLower();

            if (type != "create" ^ type != "move" ^ type != "delete")
            {
                Console.WriteLine("Invalid operation!");

                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Enter file name:");
                string fileName = Console.ReadLine();

                if (type == "create")
                {
                    CreateFile(fileName);
                }
                else if (type == "move")
                {
                    MoveFile(fileName);
                }
                else if (type == "delete")
                {
                    DeleteFile(fileName);
                }
            }

        }
        public static void DeleteFile(string userFile)
        {
            string fileRoot = @"C:\Users\lena_\source\repos\WorkingWithFiles\Data\";

            string filePath = fileRoot + userFile + ".txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"File {userFile}.txt was deleted");
            }
            else
            {
                Console.WriteLine($"File {userFile}.txt was not found in Data");
            }
        }
        public static void MoveFile(string userFile)
        {
            string fileRoot = @"C:\Users\lena_\source\repos\WorkingWithFiles\Data\";
            string dest = @"C:\Users\lena_\source\repos\WorkingWithFiles\MyData\";

            string filePath = fileRoot + userFile + ".txt";

            if (File.Exists(filePath))
            {
                File.Move(filePath, dest + userFile + ".txt");
                Console.WriteLine($"File {userFile}.txt was moved to a myData folder");
            }
            else
            {
                Console.WriteLine($"File {userFile}.txt was not found in Data");
            }
        }
        public static void CreateFile(string userFile)
        {
            string fileRoot = @"C:\Users\lena_\source\repos\WorkingWithFiles\Data\";
            string filePath = fileRoot + userFile + ".txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine($"File {userFile}.txt already exists in {fileRoot}");
            }
            else
            {
                File.Create(filePath);
                Console.WriteLine($"File {userFile}.txt has been created {fileRoot}");
            }
        
    



    }
    }
}
