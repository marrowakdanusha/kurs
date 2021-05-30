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
    public partial class addcity : Form
    {

        DataTable data;
        NpgsqlConnection _conn;
        NpgsqlCommand add_Command;
        string command_add;
        string city;
        public addcity(NpgsqlConnection __conn)
        {
            _conn = __conn;
            InitializeComponent();
        }
            private void addcity_Load(object sender, EventArgs e)
        {
            country_Load();
        }

            private void country_Load()
        {
            string command = "SELECT * FROM country";
            Load_DataTable(command);
            comboBox4.DataSource = data;
            comboBox4.ValueMember = "id_country";
            comboBox4.DisplayMember = "country";
        }
        
        public void Load_DataTable(string command)
        {
            NpgsqlDataAdapter reader = new NpgsqlDataAdapter(command, _conn);
            data = new DataTable();
            DataSet ds = new DataSet();
            ds.Reset();
            reader.Fill(ds);
            data = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            city = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Введите город"); return; }
            if (comboBox4.SelectedItem != null && textBox1.Text != "")
                command_add = $"INSERT INTO city(city, id_country) VALUES('{textBox1.Text}',{Convert.ToInt32(comboBox4.SelectedValue.ToString())})";
                add_Command = new NpgsqlCommand(command_add, _conn);
                try
                {
                    add_Command.ExecuteNonQuery();
                    Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Проверьте введённые данные");
                }
            }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

