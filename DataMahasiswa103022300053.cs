using System;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok_5
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
    }
    class DataMahasiswa103022300053
    {
        public static void ReadJSON()
        {
            string filePath = "jurnal7_1_103022300053.json";
            try {
                string jsonString = File.ReadAllText(filePath);
                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
                Console.WriteLine($"Nama: {mhs.firstName}{mhs.lastName}");
                Console.WriteLine($"Gender: {mhs.gender}");
                Console.WriteLine($"Age: {mhs.age}");
                Console.WriteLine($"Address: {mhs.address}");
                Console.WriteLine($"Courses: ");
                foreach (var course in mhs.courses)
                {
                    Console.WriteLine($" Code: {course.code}, Name: {course.name}");
                }
            }
            catch(Exception ex){
                Console.WriteLine($"Terjadi Error : {ex.Message}");
            }
        }
    }
}
