using Newtonsoft.Json;
using SemestralniPrace_JanHolda.Functions.Table;
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

namespace SemestralniPrace_JanHolda.PopUps
{
    public partial class Napoje : Form
    {
        public event EventHandler DoneWorking;
        public Napoje()
        {
            InitializeComponent();
            LoadData();
        }
        //Načtení dat do NumericBoxu
        private void LoadData()
        {
            string filePath = "bar.json";
            string jsonData = File.ReadAllText(filePath);
            List<TableData> dataList = JsonConvert.DeserializeObject<List<TableData>>(jsonData);
            foreach (var data in  dataList)
            {
                switch(data.name)
                {
                    case "Protein Nutrend":
                        PNutNum.Value = data.qty;
                        break;
                    case "Iontový nápoj Reflex":
                        IRefNum.Value = data.qty;
                        break;
                    case "Sacharid Gymbeam":
                        SGymNum.Value = data.qty;
                        break;
                    case "Protein Gymbeam":
                        PGymNum.Value = data.qty;
                        break;
                    case "Sacharid Nutrend":
                        SNutNum.Value = data.qty;
                        break;
                    default:
                        break;
                }
            }
        }
        //Uložení hodnot z NumericBoxu do souboru
        private void NapojePButton_Click(object sender, EventArgs e)
        {
            string filePath = "bar.json";
            string jsonData = File.ReadAllText(filePath);
            List<TableData> dataList = JsonConvert.DeserializeObject<List<TableData>>(jsonData);
            foreach (var data in dataList)
            {
                int a = 0;
                switch (data.name)
                {
                    case "Protein Nutrend":
                        a = Decimal.ToInt32(PNutNum.Value);
                        StaticTable.UpdateQtyBar("Protein Nutrend", a);
                        break;
                    case "Iontový nápoj Reflex":
                        a = Decimal.ToInt32(IRefNum.Value);
                        StaticTable.UpdateQtyBar("Iontový nápoj Reflex", a);
                        break;
                    case "Sacharid Gymbeam":
                        a = Decimal.ToInt32(SGymNum.Value);
                        StaticTable.UpdateQtyBar("Sacharid Gymbeam", a);
                        break;
                    case "Protein Gymbeam":
                        a = Decimal.ToInt32(PGymNum.Value);
                        StaticTable.UpdateQtyBar("Protein Gymbeam", a);
                        break;
                    case "Sacharid Nutrend":
                        a = Decimal.ToInt32(SNutNum.Value);
                        StaticTable.UpdateQtyBar("Sacharid Nutrend", a); 
                        break;
                    default:
                        break;
                }
            }
            DoneWorking?.Invoke(this, EventArgs.Empty);
        }
    }
}
