using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sirDeConectare;

            sirDeConectare = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\c# INVATARE\BD\Users.accdb; Persist Security Info=False;";
            OleDbConnection conexiune;
            conexiune = new OleDbConnection();
            conexiune.ConnectionString = sirDeConectare;
            conexiune.Open();

            MessageBox.Show("Conexiune realizata cu succes!");


        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = GetConnection();
            string nume;
            string parola;

            nume = nameBox1.Text;
            parola = passBox2.Text;


            OleDbCommand salveazaCommand = new OleDbCommand();
            salveazaCommand.Connection = connection;





        }
        private static OleDbConnection GetConnection()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\c# INVATARE\BD\Users.accdb; Persist Security Info=False;";

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu s-a putut realiza conexiunea la BD!" + ex.Message);
                return null;
            }

            return connection;
        }
    }
}
