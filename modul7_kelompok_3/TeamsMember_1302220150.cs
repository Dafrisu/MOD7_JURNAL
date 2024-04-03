using System;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class TeamMembers
{
    [JsonPropertyName("members")]
	public Member[] member {  get; set; }
    public String Json2 = System.IO.File.ReadAllText(@"C:\Users\haika\Downloads\Jurnal online\MOD7_JURNAL\jurnal7_2_1302220150.json");

    public void ReadJSON()
    {
        //Console.WriteLine("input Json: " + Json2);
        var teamset = JsonSerializer.Deserialize<TeamMembers>(Json2);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"member{i + 1}: <{teamset.member[i].nim}> <{teamset.member[i].firstname} {teamset.member[i].lastname}> (<{teamset.member[i].age}> <{teamset.member[i].gender}>)");
            /*
            Console.WriteLine($"\tName: {teamset.member[i].firstname} {teamset.member[i].lastname}");
            Console.WriteLine($"\tGender: {teamset.member[i].gender}");
            Console.WriteLine($"\tAge: {teamset.member[i].age}");
            Console.WriteLine($"\tNIM: {teamset.member[i].nim}");
            */
        }
    }
}
public class Member
{
    [JsonPropertyName("firstName")]
    public String firstname { get; set; }
    [JsonPropertyName("lastName")]
    public String lastname { get; set; }
    [JsonPropertyName("gender")]
    public String gender { get; set; }
    [JsonPropertyName("age")]
    public int age { get; set; }
    [JsonPropertyName("nim")]
    public String nim {  get; set; } 
}