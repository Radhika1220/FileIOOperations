using System;

namespace FileIOOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operations");
            string path = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileText.txt";
            FileOperations.FilExists(path);
        }
    }
}
