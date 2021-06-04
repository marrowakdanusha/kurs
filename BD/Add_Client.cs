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
    public partial class Add_Client : Form
    {
        string command_add, surname, name, patronymic, adress, jobplace;
        int year, month, day;
        NpgsqlCommand add_Command;
        DataTable data;
        NpgsqlConnection connection;
        
        public Add_Client(string info, NpgsqlConnection cconn, int id_room)
        {
            connection = cconn;
            InitializeComponent();
        }

        public void socialstatus_Load() {
            {
                string command = "SELECT * FROM socialstatus";
                Load_DataTable(command);
                comboBox1.DataSource = data;
                comboBox1.ValueMember = "id_socialstatus";
                comboBox1.DisplayMember = "socialstatus";
            } 
        }

        public void city_Load() {
            {
                string command = "SELECT * FROM city";
                Load_DataTable(command);
                comboBox4.DataSource = data;
                comboBox4.ValueMember = "id_city";
                comboBox4.DisplayMember = "city";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Введите фамилию"); return; }
            if (textBox3.Text == "") { MessageBox.Show("Введите имя"); return; }
            if (textBox4.Text == "") { MessageBox.Show("Введите отчество"); return; }
            if (textBox5.Text == "") { MessageBox.Show("Введите адрес"); return; }
            if (textBox2.Text == "") { MessageBox.Show("Введите адрес"); return; }
            if (comboBox1.SelectedItem != null && comboBox4.SelectedItem != null && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                if (dateTimePicker1.Value.Date < DateTime.Now.Date) { }
            else { MessageBox.Show("Не планируйте своё рождения на будущее..."); return; }
            command_add = $"INSERT INTO client(surname_client, name_client, patronymic_client, id_city, id_socialstatus, adress, job, birthday) VALUES('{textBox1.Text}','{textBox3.Text}','{textBox4.Text}',{Convert.ToInt32(comboBox4.SelectedValue.ToString())},{Convert.ToInt32(comboBox1.SelectedValue.ToString())},'{textBox5.Text}','{textBox2.Text}','{year}/{month}/{day}')";
            add_Command = new NpgsqlCommand(command_add, connection);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            patronymic = textBox4.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            name = textBox3.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            jobplace = textBox2.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            surname = textBox1.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            adress = textBox5.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            day = dateTimePicker1.Value.Day;
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Client_Load(object sender, EventArgs e)
        {
            socialstatus_Load();
            city_Load();
        }

       

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
