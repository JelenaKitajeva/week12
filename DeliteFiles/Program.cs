using System;
using System.IO;

namespace DeliteFiles

{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine($"Enter the name of file to delete:");
            string fileName = Console.ReadLine();
            DeleteFile(fileName);
            

        }
        public static void DeleteFile(string userFile)
        {
            string sourcePath = @"C:\Users\lena_\source\repos\WorkingWithFiles\Data\";
            string filePath = sourcePath + userFile + ".txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"File {userFile}.txt has been delite.");
            }
            else
            {
                Console.WriteLine($"File {userFile}.txt not found.");
            }
        }
    }
}
