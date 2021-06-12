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
    public partial class fullreceipt : Form
    {
        DataTable data;
        NpgsqlConnection connection;
        NpgsqlCommand command, Add_command;
        string command_Add, aim, id_client, n_id_receipt, n_surname_client, n_service, n_staff_surname;
        int day, month, year, day1, month1, year1, n_id_room;

        public fullreceipt(NpgsqlConnection cconn, string id_repeipt, DateTime checkin_date, DateTime departure_date, bool payment_incash, bool book, string aim, string surname_client, string service,  string staff_surname, int id_room)
        {
            connection = cconn;
            n_id_receipt = id_repeipt;
            textBox1.Text = aim;
            n_id_room = id_room;
            n_surname_client = surname_client;
            n_service = service;
            n_staff_surname = staff_surname;
            dateTimePicker1.Value = checkin_date;
            dateTimePicker2.Value = departure_date;
            checkBox1.Checked = payment_incash;
            checkBox2.Checked = book;
            InitializeComponent();
        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            day = dateTimePicker1.Value.Day;
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            day1 = dateTimePicker2.Value.Day;
            month1 = dateTimePicker2.Value.Month;
            year1 = dateTimePicker2.Value.Year;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void fullreceipt_Load(object sender, EventArgs e)
        {
            
            string command1 = $"SELECT id_room FROM room where id_room = {n_id_room}";
            NpgsqlCommand acommand = new NpgsqlCommand(command1, connection);
            comboBox2.Text = acommand.ExecuteScalar().ToString();
            comboBox2.Enabled = false;

            string command2 = $"SELECT surname_client FROM client where id_client = {id_client}";
            NpgsqlCommand bcommand = new NpgsqlCommand(command2, connection);
            comboBox1.Text = bcommand.ExecuteScalar().ToString();
            comboBox1.Enabled = false;

           
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

            client_Load();
            room_Load();
            staff_Load();
            extraservice_Load();
        }

        private void client_Load()
        {
            string command = "SELECT * FROM client";
            Load_DataTable(command);
            comboBox3.DataSource = data;
            comboBox3.ValueMember = "id_client";
            comboBox3.DisplayMember = "surname_client";
        }
        
        private void room_Load()
        {
            string command = "SELECT * FROM room";
            Load_DataTable(command);
            comboBox3.DataSource = data;
            comboBox3.ValueMember = "id_room";
            comboBox3.DisplayMember = "id_room";
        }

        private void staff_Load()
        {
            string command = "SELECT * FROM staff";
            Load_DataTable(command);
            comboBox3.DataSource = data;
            comboBox3.ValueMember = "id_staff";
            comboBox3.DisplayMember = "staff_surname";
        }
        private void extraservice_Load()
        {
            string command = "SELECT * FROM extraservice";
            Load_DataTable(command);
            comboBox4.DataSource = data;
            comboBox4.ValueMember = "id_extraservice";
            comboBox4.DisplayMember = "service";
        }

        public void Load_DataTable(string command)
        {
            NpgsqlDataAdapter reader = new NpgsqlDataAdapter(command, connection);
            data = new DataTable();
            DataSet ds = new DataSet();
            ds.Reset();
            reader.Fill(ds);
            data = ds.Tables[0];
        }

    }
}
