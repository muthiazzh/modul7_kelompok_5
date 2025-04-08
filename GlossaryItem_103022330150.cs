using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok_5
{
    public class GlossaryItem_103022330150
    {
        public class GlossaryRoot
        {
            public Glossary glossary { get; set; }
        }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public static void ReadJSON()
        {
            string path = "C:/Konstruksi PL/modul7/modul7_kelompok_5/jurnal7_3_103022330150.json";
            string jsonString = File.ReadAllText(path);
            GlossaryRoot data = JsonSerializer.Deserialize<GlossaryRoot>(jsonString);

            var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("GlossEntry:");
            Console.WriteLine($"  ID: {entry.ID}");
            Console.WriteLine($"  SortAs: {entry.SortAs}");
            Console.WriteLine($"  GlossTerm: {entry.GlossTerm}");
            Console.WriteLine($"  Acronym: {entry.Acronym}");
            Console.WriteLine($"  Abbrev: {entry.Abbrev}");
            Console.WriteLine($"  GlossDef:");
            Console.WriteLine($"    Para: {entry.GlossDef.para}");
            Console.WriteLine("    GlossSeeAlso: " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
            Console.WriteLine($"  GlossSee: {entry.GlossSee}");
        }
    }
}

