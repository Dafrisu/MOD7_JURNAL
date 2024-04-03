using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace modul7_kelompok_3
{
    internal class DataMahasiswa_1302220140
    {
        
        [JsonPropertyName("Nama")]
        public Nama Name { get; set; }

        [JsonPropertyName("Gender")]
        public int Gender { get; set; }

        [JsonPropertyName("Age")]
        public int Age { get; set; }

        [JsonPropertyName("Address")]
        public string Address { get; set; }

        [JsonPropertyName("Course")]
        public string Course { get; set; }

        public String json = System.IO.File.ReadAllText(@"C:\Users\USER\jurnal7_1_1302220140.json");

        public class Nama
        {
            [JsonPropertyName("depan")]
            public string Depan { get; set; }

            [JsonPropertyName("belakang")]
            public string Belakang { get; set; }
        }

        public class address
        {
            [JsonPropertyName("StreetAddress")]
            public string StreetAddress { get; set; }

            [JsonPropertyName("City")]
            public string City { get; set; }

            [JsonPropertyName("State")]
            public string State { get; set; }
        }

        public class course
        {
            [JsonPropertyName("Code")]
            public string Code { get; set; }

            [JsonPropertyName("Name")]
            public string Name { get; set; }
        }
        
        public void ReadJSON()
        {
            Console.WriteLine("Input Json: " + json);
        }

        public DataMahasiswa_1302220140()
        {

        }

    }
}
