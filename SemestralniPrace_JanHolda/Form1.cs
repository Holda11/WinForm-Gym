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

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = BoxUserName.Text;
            password = BoxUserPass.Text;

            var TryLogin = StaticLogin.TryLoginFile(username,password);
            if(TryLogin == true)
            {
            this.Hide();
            Dashboard dashboard = new Dashboard();

            dashboard.ShowDialog();

            Application.Exit(); 
            }
            
        }
    }
}
