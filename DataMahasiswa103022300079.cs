using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022300079
{
    public string Nama { get; set; }
    public string NIM { get; set; }
    public string Kelas { get; set; }
    public string MataKuliah { get; set; }

    public static void ReadJSON()
    {
        string path = "jurnal7_1_103022300079.json";
        string jsonString = File.ReadAllText(path);
        var data = JsonSerializer.Deserialize<DataMahasiswa103022300079>(jsonString);
        Console.WriteLine($"Nama: {data.Nama}, NIM: {data.NIM}, Kelas: {data.Kelas}, Mata Kuliah: {data.MataKuliah}");
    }
}
