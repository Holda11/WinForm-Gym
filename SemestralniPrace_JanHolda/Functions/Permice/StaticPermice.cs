using Newtonsoft.Json;
using SemestralniPrace_JanHolda.Functions.Login;
using SemestralniPrace_JanHolda.Functions.Table;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace SemestralniPrace_JanHolda.Functions.Permice
{
    public class PermiceData
    {
        public string Firstname { get; set ;}
        public string Lastname { get; set ; }
        public int Age {  get; set ; }
        public string PermType { get; set ; }
        public string Platba { get; set ; }
        public string Note { get; set ; }
    }
    public class StaticPermice
    {
        public static void CreatePermiceFile()
        {
            string filePath = "permice.json";

            if (!File.Exists(filePath))
            {
                List<PermiceData> seznam = new List<PermiceData>();

                // Serializace pole dat do JSON formátu pomocí Newtonsoft.Json
                string jsonData = JsonConvert.SerializeObject(seznam);

                // Zápis dat do souboru
                File.WriteAllText(filePath, jsonData);

                Console.WriteLine("Soubor byl vytvořen.");
            }
            else
            {
                Console.WriteLine("Soubor již existuje");
            }

        }
        public static void AddPermice(PermiceData data, string category)
        {
            string filePath = "permice.json";
            List<PermiceData> seznam;

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                seznam = JsonConvert.DeserializeObject<List<PermiceData>>(jsonData);
                StaticTable.UpdateQtyAttendance(category);
            }
            else
            {
                seznam = new List<PermiceData>();
            }

            seznam.Add(data);


            string newData = JsonConvert.SerializeObject(seznam);
            File.WriteAllText(filePath, newData);
        }
    }
}
