using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using MySql.Data;


namespace demonstracao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnLogar_Click_1(object sender, EventArgs e)
        {
            bool Logan = false;
            string Senha = txtSenha.Text;
            string TestLogan;
            string TestSagan;
            string Login = txtLogin.Text;
            DataBase Banco = new DataBase();
            Banco.openBar("localhost", "root", "root", "gilgameshBeta");
            Banco.getCommand("SELECT * from usuario");
            while (Banco.Selected.Read())
            {
                TestLogan = Banco.Selected[0].ToString();
                TestSagan = Banco.Selected[2].ToString();

                if (Login == TestLogan && Senha == TestSagan)
                {
                    Logan = true;

                }

            }

            if (Logan)
            {
                MessageBox.Show("Olá, senhor(a) " + Login);
                Form2 ledPlus = new Form2();
                ledPlus.Show();
                this.Hide();
                Banco.Refresh();

            }
            else
            {
                MessageBox.Show("Credenciais Inválidas");

            }
            Banco.Refresh();
        }
    }
}