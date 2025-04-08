using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static modul7_kelompok_5.DataMahasiswa_103022330150;

namespace modul7_kelompok_5
{
    class TeamMembers_103022330150
    {
        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public class Group
        {
            public List<Member> members { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "C:/Konstruksi PL/modul7/modul7_kelompok_5/jurnal7_2_103022330150.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                Group group = JsonSerializer.Deserialize<Group>(jsonString);
                
                Console.WriteLine($"Team member list:");
                foreach (var member in group.members)
                {
                    Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} {member.age} {member.gender}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File JSON tidak ditemukan");
            }
            catch (JsonException)
            {
                Console.WriteLine("Format JSON tidak valid");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
