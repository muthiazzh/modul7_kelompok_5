using modul7_kelompok_5;

public class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa_103022330150 dataMahasiswa = new DataMahasiswa_103022330150();
        dataMahasiswa.ReadJSON();

        TeamMembers_103022330150 teamMembers = new TeamMembers_103022330150();
        teamMembers.ReadJSON();
    }
}
