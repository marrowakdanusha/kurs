using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace BD
{
    public partial class Login : Form
    {
        string IP, login, password;
        NpgsqlConnection conn = null;
        bool connect=false;

        private void IPText_TextChanged(object sender, EventArgs e)
        {
            IP = IPText.Text;
        }

        private void Login_Text_TextChanged(object sender, EventArgs e)
        {
            login = Login_Text.Text;
        }

        private void Pass_Text_TextChanged(object sender, EventArgs e)
        {
            password = Pass_Text.Text;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var connString = $"Host={IP};Username={login};Password={password};Database=Hostel";
            conn = new NpgsqlConnection(connString);
            try
            {
                await conn.OpenAsync();
                connect = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Вход в БД не был выполнен.Проверьте параметры");
                connect = false;
            }

            if (connect == true)
            {
                Hide();
                new Main(conn).ShowDialog();
                Environment.Exit(0);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Course for the second-year student of the PI-19B group, Daniil Chumarin \n" +
               "designed to work with hotel databases.");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPText.Text = "127.0.0.1";
            Login_Text.Text = "postgres";
            Pass_Text.Text = "Denxds2000EDGE";

        }
    }
}
