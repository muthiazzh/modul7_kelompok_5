using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    class DataMahasiswa_103022330150
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
            public int age { get; set; }
            public Address address { get; set; }
            public List<Course> courses { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "C:/Konstruksi PL/modul7/modul7_kelompok_5/jurnal7_1_103022330150.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
                Console.WriteLine($"Nama: {data.firstName} {data.lastName}");
                Console.WriteLine($"Gender: {data.gender}");
                Console.WriteLine($"Umur: {data.age}");
                Console.WriteLine($"Alamat:");
                Console.WriteLine($"    Jalan: {data.address.streetAddress}");
                Console.WriteLine($"    Kota: {data.address.city}");
                Console.WriteLine($"    Provinsi: {data.address.state}");
                Console.WriteLine($"Mata Kuliah:");
                foreach (var course in data.courses)
                {
                    Console.WriteLine($"    Kode: {course.code}, Nama: {course.name}");
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
