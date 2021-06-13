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
        string command_Add, aim, id_client, n_id_receipt, n_surname_client, n_service, n_staff_surname, n_id_room;
        int day, month, year, day1, month1, year1;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public fullreceipt(NpgsqlConnection cconn, string id_repeipt, DateTime checkin_date, DateTime departure_date, bool payment_incash, bool book, string aim, string surname_client, string service,  string staff_surname, string id_room)
        {
            InitializeComponent();
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

       
            comboBox4.SelectedIndex = -1;
            comboBox4.SelectedText = n_service;
            comboBox4.Enabled = false;
            comboBox2.SelectedIndex = -1;
            comboBox2.SelectedText = n_id_room;
            comboBox2.Enabled = false;
            comboBox3.SelectedIndex = -1;
            comboBox3.SelectedText = n_staff_surname;
            comboBox3.Enabled = false;
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedText = n_surname_client;
            comboBox1.Enabled = false;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

        }

     

    }
}
