using SemestralniPrace_JanHolda.Functions.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralniPrace_JanHolda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Login Function
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //Proměnné pro login
            string username;
            string password;

            //Přiřazení hodnoty pro proměnné
            username = BoxUserName.Text;
            password = BoxUserPass.Text;

            //Ukládání výsledku TryLoginFile metody
            var TryLogin = StaticLogin.TryLoginFile(username,password);
            
            //Validace
            if(TryLogin == true)
            {
            this.Hide();
            Dashboard dashboard = new Dashboard();

            dashboard.ShowDialog();

            Application.Exit(); 
            }
            else
            {
                MessageBox.Show("Špatně zadané údaje");
            }
            
        }
    }
}
