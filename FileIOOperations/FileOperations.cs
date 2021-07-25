using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOOperations
{
    public class FileOperations
    {
        /// <summary>
        /// file exists or not
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool FilExists(string path)
        {
            try
            {
                if(File.Exists(path))
                {
                    Console.WriteLine("File exists");
                    return true;
                }
                else
                {
                    Console.WriteLine("File not exists");
                    return false;
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Read all lines in a file
        /// </summary>
        public static void ReadAllLinesInFile()
        {
            try
            {
                string[] lines;
                string path = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileText.txt";
                lines = File.ReadAllLines(path);
                if (lines.Length != 0)
                {
                    foreach (var i in lines)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ReadAllTextInFile()
        {
            try
            {
                string text;
                string path = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileText.txt";
                text = File.ReadAllText(path);
                if (text.Length != 0)
                {
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("File does not contain text");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}