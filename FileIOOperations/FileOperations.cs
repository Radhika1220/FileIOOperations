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
        /// Read all lines in a file - ReadAllLines returns an array of string 
        /// </summary>
        public static void ReadAllLinesInFile()
        {
            try
            {
                string path = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileText.txt";
                FilExists(path);
                string[] lines;
                lines = File.ReadAllLines(path);
                if (lines.Length != 0)
                {
                    foreach (var i in lines)
                    {
                        Console.WriteLine(i + " ");
                    }
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
        /// <summary>
        /// ReadAllText - returns a single string containing all the lines of the file
        /// </summary>
        public static void ReadAllTextInFile()
        {
            try
            {
                string path = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileText.txt";
                FilExists(path);
                string text;
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
        /// <summary>
        /// Copy File-If third parameter is true, the Copy method will overwrite if file already exists.
        /// </summary>
        public static void CopyFile()
        {
            string sourcePath = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileText.txt";
            string destPath= @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileText1.txt";
            try
            {
                File.Copy(sourcePath, destPath, true);
                Console.WriteLine("file is copied successfully");
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }
    }
}