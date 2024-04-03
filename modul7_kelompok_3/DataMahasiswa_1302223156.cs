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
    internal class DataMahasiswa_1302223156
    {
        public DataMahasiswa_1302223156() { 
        
        }
        
        [JsonPropertyName("firstname")]
        public string firstname { get; set; }
        
        [JsonPropertyName("lastname")]
        public string lastname { get; set; }
        
        [JsonPropertyName("gender")]
        public string gender { get; set; }
        
        [JsonPropertyName("age")]
        public int age { get; set; }
        
        [JsonPropertyName("address")]
        public address alamat { get; set; }
        
        [JsonPropertyName("courses")]
        public courses matkul { get; set; }

        public String json = System.IO.File.ReadAllText(@"C:\Users\daffa\Documents\File semester 4\TP KPL\Jurnal\modul7_kelompok_3\jurnal7_1_1302223156.json");
        public class address
        {
            [JsonPropertyName("streetAddress")]
            public string streetAddress { get; set; }

            [JsonPropertyName("city")]
            public string city { get; set; }

            [JsonPropertyName("state")]
            public string state { get; set; }
        }
        public class courses
        {
            [JsonPropertyName("code")]
            public string code { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }
        }

        public void ReadJSON()
        {
            Console.WriteLine("Input Json: " + json);
        }
        
    }
}
