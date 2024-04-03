using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DataMahasiswa
{	
	public class data()
	{
        public string gender;
        public int age;
        public string first_name;
        public string last_name;
    }

    public class address()
    {
        public string streetaddress;
        public string city;
        public string state;
    }

    public class courses()
    {
        public string code;
        public string name;
    }

    public class data2()
    {
        [JsonInclude]
        public string gender;
        [JsonInclude]
        public int age;
        [JsonInclude]
        public string first_name;
        [JsonInclude]
        public string last_name;
    }

    public class address2()
    {
        [JsonInclude]
        public string streetaddress;
        [JsonInclude]
        public string city;
        [JsonInclude]
        public string state;
    }

    public class courses2()
    {
        [JsonInclude]
        public string code;
        [JsonInclude]
        public string name;
    }
    
    public string json = System.IO.File.ReadAllText("@C:\\Users\\ASUS\\Documents\\KPL\\JurnalMOD7\\MOD7_JURNAL\\modul7_kelompok_3\\jurnal7_1_1302223154.json");

    public void ReadJSON()
    {
        Console.WriteLine(json);
    }
}
