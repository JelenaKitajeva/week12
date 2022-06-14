using System;
using System.IO;

namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Enter the file name to be moved from Data to MyData:");
            string fileName = Console.ReadLine();

            MoveFile(fileName);

        }
        public static void MoveFile(string userFile)
        {

            string sourceDirectory = @"C:\Users\lena_\source\repos\WorkingWithFiles\Data\";
            string destinationDirectory = @"C:\Users\lena_\source\repos\WorkingWithFiles\MyData\";

            string filePath = sourceDirectory + userFile + ".txt";

            if (File.Exists(filePath))
            {
                File.Move(filePath, destinationDirectory + userFile + ".txt");
                Console.WriteLine($"File {userFile} has been moved to a new directory.");
            }
            else
            {
                Console.WriteLine($"{userFile} not found in Data.");
            }
        }
    }
}
