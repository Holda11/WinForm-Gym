﻿using SemestralniPrace_JanHolda.Functions.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralniPrace_JanHolda.PopUps
{
    public partial class Vstupy : Form
    {
        public event EventHandler DoneWorking;

        string Choosen = "Klasický Vstup";
        public Vstupy()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            StaticTable.UpdateQtyAttendance(Choosen);
            DoneWorking?.Invoke(this, EventArgs.Empty);
        }

        private void NormalRButt_CheckedChanged(object sender, EventArgs e)
        {
            Choosen = NormalRButt.Text;
        }

        private void StudentRButt_CheckedChanged(object sender, EventArgs e)
        {
            Choosen = StudentRButt.Text;
        }

        private void DuchodRButt_CheckedChanged(object sender, EventArgs e)
        {
            Choosen = DuchodRButt.Text;
        }
    }
}
