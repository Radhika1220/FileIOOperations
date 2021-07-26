﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace FileIOOperations
{
    class CsvOperations
    {
        public static string importFilePath = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\csvdata.csv";
        //Read Content of CSV File and Print
        public static void ImplementCSVOperation()
        {
            //Initialization

            using var reader = new StreamReader(importFilePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            while (csv.Read())
            {
                var name = csv.GetField(0);
                var email = csv.GetField(1);
                var phone = csv.GetField(2);
                var country = csv.GetField(3);
                Console.WriteLine("Name: {0} \t Email: {1} \t Phone Number: {2} \t Country: {3}", name, email, phone, country);
            }
        }
        //Write Contents into CSV File
        public static void WriteCSVOperation()
        {
            string exportFile = @"C:\Users\Radhika\source\repos\FileIOOperations\FileIOOperations\csvdata.csv";
            using var writer = new StreamWriter(exportFile);

            using var csvWrite = new CsvWriter(writer, CultureInfo.InvariantCulture);

            List<Person> data = new List<Person>
            {
            new Person("Sumathi","suma@yahoo.com",8964856932,"India") };
            csvWrite.WriteRecords(data);
            csvWrite.NextRecord();
        }

    }
    }
