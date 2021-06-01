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
using Npgsql;

namespace BD
{
    public partial class infoclient : Form
    {
        DataTable data;
        NpgsqlConnection cconn;
        int id_room, n_id_client, SearchSort, id_client;
        string id_roomtype, n_id_roomtype, surname_client, name_client, patronymic_client, job, id_city, id_socialstatus, adress, searchText, tablecommand, info, sql_info, n_surname_client, n_name_client;
        string n_patronymic_client, n_job, n_birthday, n_id_city, n_id_socialstatus, n_adress, surname, name, patronymic;
        DataSet ds = new DataSet();
        NpgsqlDataAdapter InfoDataAdapter, dataAdapter1;



        public infoclient(NpgsqlConnection _conn, int id_client,string surname_client,string name_client,string patronymic_client,string job,string birthday,string id_city,string id_socialstatus,string adress)
        {
            InitializeComponent();
            cconn = _conn;
            n_id_client = id_client;
            n_surname_client = surname_client;
            n_name_client = name_client;
            n_patronymic_client = patronymic_client;
            n_job = job;
            n_birthday = birthday;
            n_id_city= id_city;
            n_id_socialstatus = id_socialstatus;
            n_adress= adress;


        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBox6.Text);
            }
            catch (Exception exp)
            {
                textBox6.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            surname = textBox1.Text;
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            patronymic = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            name = textBox2.Text;

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void Socialstatus_Load()
        {
            sql_info = ($"SELECT * FROM socialstatus");
            NpgsqlDataAdapter reader = new NpgsqlDataAdapter(sql_info, cconn);
            data = new DataTable();
            DataSet ds = new DataSet();
            ds.Reset();
            reader.Fill(ds);
            data = ds.Tables[0];
            comboBox1.DataSource = data;
            comboBox1.ValueMember = "id_socialstatus";
            comboBox1.DisplayMember = "socialstatus";
        }
        public void City_Load()
        {
            sql_info = ($"SELECT * FROM city");
            NpgsqlDataAdapter reader = new NpgsqlDataAdapter(sql_info, cconn);
            data = new DataTable();
            DataSet ds = new DataSet();
            ds.Reset();
            reader.Fill(ds);
            data = ds.Tables[0];
            comboBox1.DataSource = data;
            comboBox1.ValueMember = "id_city";
            comboBox1.DisplayMember = "city";
        }
        private void infoclient_Load(object sender, EventArgs e)
        {
            Socialstatus_Load();
            City_Load();
        }
    }
}
