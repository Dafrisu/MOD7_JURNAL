using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DataMahasiswa
{
    [JsonPropertyName ("firstName")]
    public String firstname { get; set; }
    [JsonPropertyName("lastName")]
    public String lastname { get; set; }
    [JsonPropertyName("gender")]
    public String gender { get; set; }
    [JsonPropertyName("age")]
    public int age { get; set; }
    [JsonPropertyName("address")]
    public Address address {  get; set; }
    [JsonPropertyName("courses")]
    public  Courses[] courses {  get; set; }

    public String Json1 = System.IO.File.ReadAllText(@"C:\Users\haika\Downloads\Jurnal online\MOD7_JURNAL\jurnal7_1_1302220150.json");
    public class Address
    {
        [JsonPropertyName("streetAddress")]
        public String streetAddress { get; set; }
        [JsonPropertyName("city")]
        public String city { get; set; }
        [JsonPropertyName("state")]
        public String state;
    }

    public class Courses
    {
        [JsonPropertyName("code")]
        public String code { get; set; }
        [JsonPropertyName("name")]
        public String name { get; set; }
    }

    public void ReadJSON()
    {
        //Console.WriteLine("input json: " + Json1);
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        var Mahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(Json1,options);
        Console.WriteLine($"Name: {Mahasiswa.firstname} {Mahasiswa.lastname}");
        Console.WriteLine($"Gender: {Mahasiswa.gender}");
        Console.WriteLine($"Age: {Mahasiswa.age}");
        Console.WriteLine($"Address :{Mahasiswa.address.streetAddress}, {Mahasiswa.address.city}, {Mahasiswa.address.state}");
        Console.WriteLine($"Courses1: {Mahasiswa.courses[0].code} - {Mahasiswa.courses[0].name}");
        Console.WriteLine($"Courses2: {Mahasiswa.courses[1].code} - {Mahasiswa.courses[1].name}");
    }
    
}

