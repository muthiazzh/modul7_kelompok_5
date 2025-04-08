using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace modul7_kelompok_5
{
    public class alamat
    {
        public string streetaddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Mahasiswa
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public alamat address { get; set; }

    }

    public class MataKuliah
    {
        [JsonPropertyName("code")]
        public string Kode { get; set; }

        [JsonPropertyName("name")]
        public string Nama { get; set; }
    }

    public class DaftarMatkul
    {
        [JsonPropertyName("course")]
        public List<MataKuliah> Course { get; set; }
    }
    class DataMahasiswa103022330117
    {
      public static void ReadJSON()
        {
            string filepath = "jurnal7_1_103022330117.json";

            try
            {
                string jsonString = File.ReadAllText(filepath);
                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

                Console.WriteLine($"Nama : {mhs.firstname} {mhs.lastname} bergender {mhs.gender} berumur {mhs.age} beralamat {mhs.address.streetaddress} {mhs.address.city} {mhs.address.state}");

                DaftarMatkul daftar = JsonSerializer.Deserialize<DaftarMataKuliah>(jsonString);

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int i = 1;
                foreach (var mk in daftar.Courses)
                {
                    Console.WriteLine($"MK {i} {mk.Kode} - {mk.Nama}");
                    i++;
                }
            }
        }

       
    }
}
