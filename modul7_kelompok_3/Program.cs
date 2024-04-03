// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
public class program
{
    public static void Main()
    {
        DataMahasiswa mhs = new DataMahasiswa();

        var options = new JsonSerializerOptions
        {
            IncludeFields = true
        };
        var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(mhs.json,options);
        //Console.WriteLine($"mahasiswa.data2.gender");
        Console.WriteLine(mahasiswa);
    }
}
