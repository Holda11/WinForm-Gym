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
    public partial class Suplementy : Form
    {
        public event EventHandler DoneWorking;
        public Suplementy()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string filePath = "bar.json";
            string jsonData = File.ReadAllText(filePath);
            List<TableData> dataList = JsonConvert.DeserializeObject<List<TableData>>(jsonData);
            foreach (var data in dataList)
            {
                switch (data.name)
                {
                    case "Tyčinka Dafit":
                        TDafNum.Value = data.qty;
                        break;
                    case "Nakopavač CzechVirus":
                        NCzeNum.Value = data.qty;
                        break;
                    case "Tyčinka Gymbeam":
                        TGymNum.Value = data.qty;
                        break;
                    case "BCAA Dafit":
                        BDafNum.Value = data.qty;
                        break;
                    default:
                        break;
                }
            }
        }
        private void SupPButton_Click(object sender, EventArgs e)
        {
            string filePath = "bar.json";
            string jsonData = File.ReadAllText(filePath);
            List<TableData> dataList = JsonConvert.DeserializeObject<List<TableData>>(jsonData);
            foreach (var data in dataList)
            {
                int a = 0;
                switch (data.name)
                {
                    case "Tyčinka Dafit":
                        a = Decimal.ToInt32(TDafNum.Value);
                        StaticTable.UpdateQtyBar("Tyčinka Dafit", a);
                        break;
                    case "Nakopavač CzechVirus":
                        a = Decimal.ToInt32(NCzeNum.Value);
                        StaticTable.UpdateQtyBar("Nakopavač CzechVirus", a);
                        break;
                    case "Tyčinka Gymbeam":
                        a = Decimal.ToInt32(TGymNum.Value);
                        StaticTable.UpdateQtyBar("Tyčinka Gymbeam", a);
                        break;
                    case "BCAA Dafit":
                        a = Decimal.ToInt32(BDafNum.Value);
                        StaticTable.UpdateQtyBar("BCAA Dafit", a);
                        break;
                    default:
                        break;
                }
            }
            DoneWorking?.Invoke(this, EventArgs.Empty);
        }

    }
}
