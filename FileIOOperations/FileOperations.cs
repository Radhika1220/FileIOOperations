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
        public static bool FileExists(string path)
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
                FileExists(path);
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
                FileExists(path);
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
        /// <summary>
        /// Delete file -To check whether the file exists or not,If delete the particular file.
        /// </summary>
        public static void DeleteFile()
        {
            try
            {
                string delFile= @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileText1.txt";
                if(FileExists(delFile))
                {
                    File.Delete(delFile);
                    Console.WriteLine("File deleted");
                }
                else
                {
                    Console.WriteLine("File not found!!!");
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Read from stream reader class-reads a file content one line at a time and displayed it.
        /// </summary>
        public static void ReadFromStreamReader()
        {
            string streamReadPath= @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileText.txt";
            try
            {
                using(StreamReader reader =new StreamReader(streamReadPath))
                {
                    string line;
                    Console.WriteLine("\n------------Read the file from stream reader class------\n");
                    while ((line = reader.ReadLine()) != null)
                    {
                      
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        /// <summary>
        /// StreamWriter- To write in a file
        /// </summary>
        public static void WriteUsingStreamWriter()
        {
            string streamWritePath = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileText.txt";
            FileStream stream=null;
            try
            {
                stream = new FileStream(streamWritePath, FileMode.OpenOrCreate);
                 using(StreamWriter writer  =new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine("Hello..");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(stream!=null)
                {
                    stream.Dispose();
                }
            }
            string readText = File.ReadAllText(streamWritePath);
            Console.WriteLine(readText);
           
        }
    }
}