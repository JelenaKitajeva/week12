using System;
using System.IO;

namespace CreateFiles
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();

            CreateFile(fileName);
        }

        public static void CreateFile(string userFile)
        {
            string fileroot = @"C:\Users\lena_\source\repos\WorkingWithFiles\Data\";

            string filePach = fileroot + userFile + ".txt";



            if (File.Exists(filePach))
            {
                Console.WriteLine($"File {userFile}.txt already exists in {fileroot}.");
            }
            else
            {
                File.Create(filePach);
                Console.WriteLine($"File {userFile}.txt has been created in{filePach}.");
            }
        }
    }
}
