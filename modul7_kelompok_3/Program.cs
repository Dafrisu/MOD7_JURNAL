using System;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using modul7_kelompok_3;
using System.Text.Json.Serialization;
using System.Text.Json;

class Program {
  static void Main(string[] args) {
    Console.WriteLine("Bagian Daffa")
    using modul7_kelompok_3;
    using System.Text.Json.Serialization;
    using System.Text.Json;

    DataMahasiswa_1302223156 Dafa_1302223156 = new DataMahasiswa_1302223156();
    Dafa_1302223156.ReadJSON();

    var options = new JsonSerializerOptions {
      IncludeFields = true,
    };
    string jsonString = File.ReadAllText(@ "C:\Users\daffa\Documents\File semester 4\TP KPL\Jurnal\modul7_kelompok_3\jurnal7_1_1302223156.json");

    var mahasiswa = JsonSerializer.Deserialize < DataMahasiswa_1302223156 > (jsonString);
    //Console.WriteLine($"firstname: {mahasiswa.firstname}");
    //Console.WriteLine($"lastname: {mahasiswa.lastname}");
    //Console.WriteLine($"gender: {mahasiswa.gender}");
    //Console.WriteLine($"age {mahasiswa.age}");
    //Console.WriteLine($"address: {mahasiswa.alamat.streetAddress} {mahasiswa.alamat.city}{mahasiswa.alamat.state}");
    //Console.WriteLine($"courses: {mahasiswa.matkul.code} {mahasiswa.matkul.name}");

    Console.WriteLine("Bagian Mahesa - 1302220105");
    DataMahasiswa_1302220105.ReadJSON();
    Console.WriteLine(" ");
    TeamMembers_1302220105.ReadJSON();
    Console.WriteLine(" ");
  }
}