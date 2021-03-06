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
    public partial class Addreceipt : Form
    {
        DataTable data;
        NpgsqlConnection connection;
        NpgsqlCommand command, Add_command;
        string command_Add, aim, id_client;
        int day, month, year, day1, month1, year1, n1_id_room;
        public Addreceipt(NpgsqlConnection __conn, int id_room1, string n_id_client)
        {
            connection = __conn;
            n1_id_room = id_room1;
            id_client = n_id_client;
            InitializeComponent();
        }

        private void Addreceipt_Load(object sender, EventArgs e)
        {
            string command1 = $"SELECT id_room FROM room where id_room = {n1_id_room}";
            NpgsqlCommand acommand = new NpgsqlCommand(command1, connection);
            comboBox2.Text = acommand.ExecuteScalar().ToString();
            comboBox2.Enabled = false;

            string command2 = $"SELECT surname_client FROM client where id_client = {id_client}";
            NpgsqlCommand bcommand = new NpgsqlCommand(command2, connection);
            comboBox1.Text = bcommand.ExecuteScalar().ToString();
            comboBox1.Enabled = false;
            
            staff_Load();           
            extraservice_Load();
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Введите цель приезда"); return; }
         //   if (textBox1.Text == "" || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null) { MessageBox.Show("Что-то было упущено..."); return; }
            if (dateTimePicker1.Value.Date < dateTimePicker2.Value.Date) { }
            else { MessageBox.Show("Не планируйте свой отъезд даже не приехав к нам..."); return; }
            NpgsqlCommand addcommand = new NpgsqlCommand($"INSERT INTO reservation(checkin_date, departure_date, payment_incash, book, aim, id_client, id_staff, id_extraservice, id_room) VALUES('{year}/{month}/{day}', '{year1}/{month1}/{day1}', '{checkBox2.Checked}','{checkBox1.Checked}', '{textBox1.Text}', {id_client}, {(comboBox3.SelectedValue.ToString())}, {(comboBox4.SelectedValue.ToString())}, {n1_id_room} )", connection);
            try
            {
                addcommand.ExecuteNonQuery();
                Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Проверьте введённые данные");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            aim = textBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            day = dateTimePicker1.Value.Day;
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            day1 = dateTimePicker2.Value.Day;
            month1 = dateTimePicker2.Value.Month;
            year1 = dateTimePicker2.Value.Year;
        }
    }
}

