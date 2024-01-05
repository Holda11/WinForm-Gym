using Newtonsoft.Json;
using SemestralniPrace_JanHolda.Functions.Permice;
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
    public partial class Permice : Form
    {
        public event EventHandler DoneWorking;
        public Permice()
        {
            InitializeComponent();
        }

        private void PotvrditButt_Click(object sender, EventArgs e)
        {
            //Vytvoření nového objektu PermiceData
            PermiceData data = new PermiceData
            {
                Firstname = NameBox.Text,
                Lastname = PrijmeniBox.Text,
                Age = int.Parse(AgeBox.Text),
                PermType = TypeBox.Text,
                Platba = PlatbaBox.Text,
                Note = NoteBox.Text
            };
            //Volání Funkce AddPermice a přidání nové permice do souboru
            StaticPermice.AddPermice(data, data.PermType);
            DoneWorking?.Invoke(this, EventArgs.Empty);
        }
    }
}
