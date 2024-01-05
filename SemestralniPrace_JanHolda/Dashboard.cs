using Newtonsoft.Json;
using SemestralniPrace_JanHolda.Functions.Login;
using SemestralniPrace_JanHolda.Functions.Table;
using SemestralniPrace_JanHolda.PopUps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralniPrace_JanHolda
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            //Metoda pro načtení dat do tabulek
            LoadDataTable();
            //Změna Textu Lablů podle celkového množství produktů ze souborů
            PermiceTotalLabel.Text = GetTotalQty("Permice", "data.json").ToString();
            VstupyTotalLabel.Text = GetTotalQty("Vstup", "data.json").ToString();
            BarTotalLabel.Text = GetTotalQty("Napoj", "bar.json").ToString();
        }

        //Načtení dat do Tabulek
        private void LoadDataTable()
        {
            //Proměná s názvem souboru
            string filePath = "data.json";
            
            //Ověření zda soubor existuje
            if (File.Exists(filePath))
            {
                //Načtení dat ze souboru
                string jsonData = File.ReadAllText(filePath);

                //Deserializace dat
                List<TableData> tableDatalist = JsonConvert.DeserializeObject<List<TableData>>(jsonData);
                
                //Nastavení Tabulky
                TableAttendance.DataSource = tableDatalist;

                //Nastavení názvu sloupců
                TableAttendance.Columns["name"].HeaderText = "Jméno";
                TableAttendance.Columns["type"].HeaderText = "Typ";
                TableAttendance.Columns["qty"].HeaderText = "Množství";
            }
            else
            {
                MessageBox.Show("Soubor neexistuje.");
            }

            //"DUPLICITA"
            //Stejný kód se změnou souboru
            string barPath = "bar.json";
            if (File.Exists(barPath))
            {
                string jsonData = File.ReadAllText(barPath);

                List<TableData> tableDatalist = JsonConvert.DeserializeObject<List<TableData>>(jsonData);


                TableBar.DataSource = tableDatalist;

                TableBar.Columns["name"].HeaderText = "Jméno";
                TableBar.Columns["type"].HeaderText = "Typ";
                TableBar.Columns["qty"].HeaderText = "Množství";
            }
            else
            {
                MessageBox.Show("Soubor neexistuje.");
            }
            
        }
        //Metoda dostání celkového množství položky
        //Požadujeme kategorii a jméno souboru
        private int GetTotalQty(string category, string path)
        {
            //načtení dat ze souboru
            string jsonData = File.ReadAllText(path);
            List<TableData> dataList = JsonConvert.DeserializeObject<List<TableData>>(jsonData);
            int totalQty = 0;
            //podmínka podle souboru, u bar.json není třeba zjišťovat kategorii
            if(path == "data.json")
            {
                foreach (var data in dataList)
                {
                    if (data.type == category)
                    {
                        totalQty += data.qty;
                    }
                }
            }
            else 
            {
                foreach (var data in dataList)
                {
                   totalQty += data.qty;
                }
            }

            return totalQty;
        }

        //Funkce pro znovu-načtení dat
        //Funkce má dva argumenty:
        //path: určuje soubor
        //first: určuje o jakou tabulku se jedná
        private void RefreshTableData(string path, bool first)
        {
            string jsonData = File.ReadAllText(path);
            List<TableData> tableDatalist = JsonConvert.DeserializeObject<List<TableData>>(jsonData);

            if (first)
            {
                TableAttendance.DataSource = tableDatalist;
                
                TableAttendance.Columns["name"].HeaderText = "Jméno";
                TableAttendance.Columns["type"].HeaderText = "Typ";
                TableAttendance.Columns["qty"].HeaderText = "Množství";
            }
            else
            {
                TableBar.DataSource = tableDatalist;

                TableBar.Columns["name"].HeaderText = "Jméno";
                TableBar.Columns["type"].HeaderText = "Typ";
                TableBar.Columns["qty"].HeaderText = "Množství";
            }
        }
        ////////////////////////////////////
        //Metody pro spuštení Pop-Up Formu//
        ////////////////////////////////////
        private void PermiceButt_Click(object sender, EventArgs e)
        {
            //Vytvoření permiceForm
            Permice permiceForm = new Permice();
            //Funkce pro zavření okna
            permiceForm.DoneWorking += (s, args) =>
            {
                if (s is Permice permice)
                {
                    permice.Close();
                }
            };
            //Funkce pro obnovení dat
            permiceForm.FormClosed += (s, args) =>
            {
                RefreshTableData("data.json", true); 
                PermiceTotalLabel.Text = GetTotalQty("Permice", "data.json").ToString();
            };
            permiceForm.ShowDialog(); 
        }

        private void VstupyButt_Click(object sender, EventArgs e)
        {
            Vstupy vstupyForm = new Vstupy();
            vstupyForm.DoneWorking += (s, args) =>
            {
                if (s is Vstupy vstupy)
                {
                    vstupy.Close();
                }
            };
            vstupyForm.FormClosed += (s, args) =>
            {
                RefreshTableData("data.json", true);
                VstupyTotalLabel.Text = GetTotalQty("Vstup", "data.json").ToString();
            };
            vstupyForm.ShowDialog();
        }

        private void NapojeButt_Click(object sender, EventArgs e)
        {
            Napoje napojeForm = new Napoje();
            napojeForm.DoneWorking += (s, args) =>
            {
                if (s is Napoje napoje)
                {
                    napoje.Close();
                }
            };
            napojeForm.FormClosed += (s, args) =>
            {
                RefreshTableData("bar.json", false);
                BarTotalLabel.Text = GetTotalQty("Napoj", "bar.json").ToString();
            };
            napojeForm.ShowDialog();
        }

        private void SuplementButt_Click(object sender, EventArgs e)
        {
            Suplementy suplementyForm = new Suplementy();
            suplementyForm.DoneWorking += (s, args) =>
            {
                if (s is Suplementy suplementy)
                {
                    suplementy.Close();
                }
            };
            suplementyForm.FormClosed += (s, args) =>
            {
                RefreshTableData("bar.json", false);
                BarTotalLabel.Text = GetTotalQty("Suplement", "bar.json").ToString();
            };
            suplementyForm.ShowDialog();
        }
    }
}
