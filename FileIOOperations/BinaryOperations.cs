using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    [Serializable]
    public class Demo
    {
        public string name { get; set; }
        public int age { get; set; }
        public Demo(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    public class BinaryOperations
    {
        //binary serialize
        public static string filepath = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileData.txt";
        public static void Serialization()
        {
            Demo demo = new Demo("Radhika", 21);
            Stream ms = File.OpenWrite(filepath);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(ms, demo);
            ms.Flush();
            ms.Close();
            ms.Dispose();

        }
        public static void DeSerialization()
        {
            string binarypath = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\FileData.txt";
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = File.Open(binarypath, FileMode.Open);
            object obj = formatter.Deserialize(fs);
            Demo d = (Demo)obj;
            fs.Flush();
            fs.Close();
            fs.Dispose();
            Console.WriteLine("Name: {0} \t Age: {1}", d.name, d.age);
        }
    }
    }