using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace modul7_kelompok_3
{
    internal class Datamahasiswa_1302223090
    {
        public class Courses
        {
            public string code { get; set; }
            public string name { get; set; }
        }
        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }
       
        public class DataMahasiswa
         {
             public string firstName { get; set; }
             public string lastName { get; set; }
             public string gender { get; set; }
             public int age { get; set; }
             public Address alamat { get; set; }
             public Courses[] courses { get; set; }
             public void Print()
             {
                Console.WriteLine($"Nama {firstName} {lastName} gender {gender} umur {age} alamat {alamat} ");
                Console.WriteLine(" - ");
                for(int i = 0; i < courses.Length; i++)
                {
                    Console.WriteLine(courses[i].name);
                    Console.WriteLine(courses[i].code);
                    Console.WriteLine(" - ");

                }
            }
           
         }
           
          public static void ReadJSON()
          {
                string fileName = "jurnal7_1_1302223090.json";
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                try
                {
                    string jsonData = File.ReadAllText(filePath);
                    DataMahasiswa DataMHS = JsonConvert.DeserializeObject<DataMahasiswa>(jsonData, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto
                    });
                DataMHS.Print();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading Json file: {ex.Message}");
                }
          }
           
    }
 }

