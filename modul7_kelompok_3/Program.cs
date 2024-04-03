// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa mhs = new DataMahasiswa();
        TeamMembers team = new TeamMembers();
        team.ReadJSON();
        //mhs.ReadJSON();
    }
}
