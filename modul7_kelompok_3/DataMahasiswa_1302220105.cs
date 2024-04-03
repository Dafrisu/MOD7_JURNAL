using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_3
{
    internal class DataMahasiswa_1302220105
    {
        public class AddressData
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }
        public class CourseData
        {
            public List<Course> courses { get; set; }
        }
        public class MahasiswaData
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public AddressData address { get; set; }
            public string gender { get; set; }
            public int age { get; set; }

            public void PrintData()
            {
                Console.WriteLine($"Nama {firstName} {lastName}, umur {age}");
                Console.WriteLine($"tinggal di {address.streetAddress}, kota {address.city}, provinsi {address.state}");
            }
        }

        public static void ReadJSON()
        {
            string fileName = "jurnal7_1_1302220105.json";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            try
            {
                string jsonData = File.ReadAllText(filePath);
                MahasiswaData mahasiswaData = JsonConvert.DeserializeObject<MahasiswaData>(jsonData, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });
                CourseData courseData = JsonConvert.DeserializeObject<CourseData>(jsonData, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });

                mahasiswaData.PrintData();

                if (courseData?.courses != null && courseData.courses.Count > 0)
                {
                    PrintCourses(courseData);
                }
                else
                {
                    Console.WriteLine("Error: No courses found in the JSON file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading JSON file: {ex.Message}");
            }
        }
        private static void PrintCourses(CourseData courseData)
        {
            Console.WriteLine("Daftar mata kuliah yang diambil:");

            int i = 1;
            foreach (var course in courseData.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
