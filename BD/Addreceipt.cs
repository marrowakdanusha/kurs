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
        string command_Add, aim;
        int day, month, year, id_room;
        public Addreceipt(NpgsqlConnection __conn)
        {
            connection = __conn;
            InitializeComponent();
        }

        private void Addreceipt_Load(object sender, EventArgs e)
        {
            client_Load();
            staff_Load();
            room_Load();
            extraservice_Load();
        }

        private void client_Load()
        {
            string command = "SELECT * FROM client";
            Load_DataTable(command);
            comboBox1.DataSource = data;
            comboBox1.ValueMember = "id_client";
            comboBox1.DisplayMember = "surname_client";
        }

        private void staff_Load()
        {
            string command = "SELECT * FROM staff";
            Load_DataTable(command);
            comboBox3.DataSource = data;
            comboBox3.ValueMember = "id_staff";
            comboBox3.DisplayMember = "staff_surname";
        }
        private void room_Load()
        {
            string command = "SELECT * FROM room";
            Load_DataTable(command);
            comboBox2.DataSource = data;
            comboBox2.ValueMember = "id_room";
            comboBox2.DisplayMember = "room";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Введите цель приезда"); return; }
            if (Convert.ToInt32(textBox3.Text) < 1) { MessageBox.Show("Кол-во дней не может быть меньше одного"); return; }
            if (textBox1.Text == "" || textBox3.Text == "" || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null) { MessageBox.Show("Что-то было упущено..."); return; }
            if (dateTimePicker1.Value.Date < dateTimePicker2.Value.Date) { }
                else { MessageBox.Show("Не планируйте свой отъезд даже не приехав к нам..."); return; }
            command_Add = ($"INSERT INTO reservation(checkin_date, departure_date, payment_incash, book, aim, id_client, id_staff, id_extraservice, id_room) VALUES('{year}/{month}/{day}', '{year}/{month}/{day}', '{checkBox2.Checked}',{checkBox1.Checked}, {textBox1.Text}, {Convert.ToInt32(comboBox1.SelectedValue.ToString())}, {Convert.ToInt32(comboBox3.SelectedValue.ToString())}, {Convert.ToInt32(comboBox4.SelectedValue.ToString())}, {Convert.ToInt32(comboBox2.SelectedValue.ToString())} ) RETURNING id_receipt");
            Add_command = new NpgsqlCommand(command_Add, connection);
            try
            {
                Add_command.ExecuteNonQuery();
                Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Проверьте введённые данные");
            }
        }
     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBox3.Text);
            }
            catch (Exception exp)
            {
                textBox3.Clear();
            }
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
            day = dateTimePicker1.Value.Day;
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
        }
    }
}

