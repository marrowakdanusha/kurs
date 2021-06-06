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
        DataSet ds = new DataSet();
        NpgsqlDataAdapter dataAdapter1 = null, InfoDataAdapter;
        DataTable data;
        NpgsqlConnection cconn;
        int id_room, day, month, year;
        string job, adress, sql_info, n_surname_client, n_name_client;
        string  n_id_client, n_id_city, n_id_socialstatus;

        public infoclient(NpgsqlConnection _conn, string id_client,string surname_client,string name_client,string patronymic_client,string job,DateTime birthday,string id_city,string id_socialstatus,string adress)
        {
            InitializeComponent();
            n_id_client = id_client;
            cconn = _conn;
            textBox1.Text = surname_client;
            textBox3.Text = name_client;
            textBox2.Text = patronymic_client;
            textBox4.Text = job;
            n_id_city = id_city;
            n_id_socialstatus = id_socialstatus;
            textBox5.Text = adress; 
            dateTimePicker1.Value = birthday;


        }

        private void button3_Click(object sender, EventArgs e)
        {
                NpgsqlCommand command = new NpgsqlCommand($"UPDATE client SET surname_client='{textBox1.Text}',name_client='{textBox3.Text}', patronymic_client='{textBox2.Text}', job='{textBox4.Text}', adress='{textBox5.Text}', id_city ={comboBox1.SelectedValue.ToString()}, id_socialstatus ={comboBox2.SelectedValue.ToString()} where id_client={n_id_client}", cconn);
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.SelectedValue == null || comboBox2.SelectedValue == null) { MessageBox.Show("Поле не может быть пустым"); return; }
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Проверьте введённые данные");
                    return;
                }
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button3.Visible = false;
                dateTimePicker1.Enabled = false;
            }
        
        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            button3.Visible = true;
            dateTimePicker1.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LoadInfo();
        }

        public void Load_DataTable(string command)
        {
            NpgsqlDataAdapter reader = new NpgsqlDataAdapter(command, cconn);
            data = new DataTable();
            DataSet ds = new DataSet();
            ds.Reset();
            reader.Fill(ds);
            data = ds.Tables[0];
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            LoadInfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Addreceipt(cconn).ShowDialog();
            LoadInfo(); Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            string command = "";
            command = $" Delete FROM reservation WHERE id_receipt ={dataGridView1.CurrentRow.Cells[0].Value}";
            if (result == DialogResult.No) { return; }
            NpgsqlCommand delete = new NpgsqlCommand(command, cconn);
            delete.ExecuteNonQuery();
            LoadInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void LoadInfo()
        {
            sql_info = ($"SELECT a.id_receipt AS ID, a.checkin_date as Дата_заселения, a.departure_date as Дата_выезда, a.payment_incash as Оплата_Наличкой, a.book as Бронирование, a.aim as Цель_приезда, p.id_client as Фамилия_клиента, s.id_extraservice as Доп_услуги, c.id_room as Номер_комнаты, j.id_staff from reservation a left join client p on(p.id_client = a.id_client) left join extraservice s on (s.id_extraservice = a.id_extraservice) left join room c on (c.id_room = a.id_room) left join staff j on (j.id_staff= a.id_staff) ORDER BY ID OFFSET ((" + (numericUpDown1.Value - 1) + ") * " + 15 + ") " +
  "ROWS FETCH NEXT " + 15 + "ROWS ONLY;");

            InfoDataAdapter = new NpgsqlDataAdapter(sql_info, cconn);
            DataTable dt = new DataTable();
            ds.Reset();
            InfoDataAdapter.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            day = dateTimePicker1.Value.Day;
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
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
            comboBox2.DataSource = data;
            comboBox2.ValueMember = "id_socialstatus";
            comboBox2.DisplayMember = "socialstatus";
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
            LoadInfo();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedText = n_id_city;
            comboBox1.Enabled = false;
            comboBox2.SelectedIndex = -1;
            comboBox2.SelectedText = n_id_socialstatus;
            comboBox2.Enabled = false;
            button3.Visible = false;
            dateTimePicker1.Enabled = false;
          
        }
    }
}
