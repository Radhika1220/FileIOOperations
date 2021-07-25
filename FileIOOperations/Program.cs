using System;

namespace FileIOOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operations");
            string path = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileText.txt";
            Console.WriteLine("Enter 1: To check whether the file exists or not");
            Console.WriteLine("Enter 2: To Read all lines in file by using ReadAllLines method");
            Console.WriteLine("Enter 3: To Read all lines in file by using ReadAllText method");
            Console.WriteLine("Enter 4: To copy a file from cource to destination");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    FileOperations.FilExists(path);
                    break;
                case 2:
                    FileOperations.ReadAllLinesInFile();
                    break;
                case 3:
                    FileOperations.ReadAllTextInFile();
                    break;
                case 4:
                    FileOperations.CopyFile();
                    break;
                default:
                    Console.WriteLine("Enter a valid option!!!");
                    break;
            }
        }
    }
}
