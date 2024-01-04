using Newtonsoft.Json;
using SemestralniPrace_JanHolda.Functions.Login;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;


namespace SemestralniPrace_JanHolda.Functions.Table
{
    public class TableData
    {
        public string name { get; set; }
        public string type { get; set; }
        public int qty { get; set; }
    }
    public class StaticTable
    {
        public static void CreateStaticTable()
        {
            string filePath = "data.json";

            if (!File.Exists(filePath))
            {

                var seedData = new List<TableData>()
                {
                    new TableData {name = "Klasický Vstup", type="Vstup", qty = 0},
                    new TableData {name = "Studentský Vstup", type="Vstup", qty=0},
                    new TableData {name = "Důchodový Vstup", type="Vstup", qty=0},
                    new TableData {name = "Klasická Permice", type = "Permice", qty = 0},
                    new TableData {name = "Studentská Permice", type = "Permice", qty=0},
                    new TableData {name = "Důdová Permice", type="Permice", qty=0}
                };
                string jsonData = JsonConvert.SerializeObject(seedData);
                File.WriteAllText("data.json", jsonData);

                Console.WriteLine("Soubor byl vytvořen.");


            }
            else
            {
                Console.WriteLine("Soubor již existuje");
            }

            string barPath = "bar.json";
            
            if (!File.Exists(barPath))
            {

                var seedData = new List<TableData>()
                {
                    new TableData {name = "Protein Nutrend", type="Napoj", qty = 0},
                    new TableData {name = "Iontový nápoj Reflex", type="Napoj", qty=0},
                    new TableData {name = "Sacharid Gymbeam", type="Napoj", qty=0},
                    new TableData {name = "Tyčinka Dafit", type = "Suplement", qty = 0},
                    new TableData {name = "Nakopavač CzechVirus", type = "Suplement", qty=0},
                    new TableData {name = "Protein Gymbeam", type="Napoj", qty=0},
                    new TableData {name = "Tyčinka Gymbeam", type="Suplement", qty=0},
                    new TableData {name = "Sacharid Gymbeam", type="Napoj", qty=0},
                    new TableData {name = "BCAA Dafit", type="Suplement", qty=0}
                };
                string jsonData = JsonConvert.SerializeObject(seedData);
                File.WriteAllText("bar.json", jsonData);

                Console.WriteLine("Soubor byl vytvořen.");


            }
            else
            {
                Console.WriteLine("Soubor již existuje");
            }
        }
        public static void UpdateQtyAttendance(string dataQty)
        {
            string filePath = "data.json";
            string jsonData = File.ReadAllText(filePath);
            List<TableData> dataList = JsonConvert.DeserializeObject<List<TableData>>(jsonData);

            foreach (var data in dataList)
            {
                if (data.name == dataQty)
                {
                    data.qty++;
                }
            }

            string newData = JsonConvert.SerializeObject(dataList);
            File.WriteAllText(filePath, newData);
        }
        public static void UpdateQtyBar(string dataName, int dataValue)
        {
            string filePath = "bar.json";
            string jsonData = File.ReadAllText(filePath);
            List<TableData> dataList = JsonConvert.DeserializeObject<List<TableData>>(jsonData);
            foreach (var data in dataList)
            {
                if (data.name == dataName)
                {
                    data.qty = dataValue;
                    break; 
                }
            }

            string newData = JsonConvert.SerializeObject(dataList);
            File.WriteAllText(filePath, newData);
        }
    }
}
