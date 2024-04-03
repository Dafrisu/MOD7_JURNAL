using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static modul7_kelompok_3.DataMahasiswa_1302220105;

namespace modul7_kelompok_3
{
    internal class TeamMembers_1302220105
    {
        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public class MembersData
        {
            public List<Member> members { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_2_1302220105.json";
            string jsonData = File.ReadAllText(filePath);

            try
            {
                MembersData membersData = JsonConvert.DeserializeObject<MembersData>(jsonData, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });

                if (membersData?.members != null && membersData.members.Count > 0)
                {
                    PrintCourses(membersData);
                }
                else
                {
                    Console.WriteLine("Error: No courses found in the JSON file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        private static void PrintCourses(MembersData membersData)
        {
            Console.WriteLine("List anggota dalam kelompok 3:");

            int i = 1;
            foreach (var members in membersData.members)
            {
                Console.WriteLine($"Anggota ke-{i}");
                Console.WriteLine($"Nama {members.firstName} {members.lastName}");
                Console.WriteLine($"Gender {members.gender}");
                Console.WriteLine($"Umur {members.age}");
                Console.WriteLine($"NIM {members.nim}");
                i++;
            }
        }
    }
}
