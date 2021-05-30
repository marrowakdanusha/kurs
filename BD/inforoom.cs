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
    public partial class inforoom : Form
    {
        DataTable data;
        NpgsqlConnection cconn;
        int id_room, n_id_room, SearchSort, id_client, Notes_SQL;
        string id_roomtype, n_id_roomtype, birthday, surname_client,name_client, patronymic_client, job, id_city,id_socialstatus, adress, image, numberofseats, floor, payment, roomtype, searchText, tablecommand, info, sql_info, n_image, n_numberofseats, n_floor, n_payment;
        
        DataSet ds = new DataSet();
        NpgsqlDataAdapter InfoDataAdapter, dataAdapter1;

        private void CountText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_SQL_TextChanged(object sender, EventArgs e)
        {
            SortSearch();
        }

        public inforoom(NpgsqlConnection _conn, int id_room, string image, string numberofseats, string floor, string payment, string id_roomtype, bool tv, bool fridge)
        {
            InitializeComponent();
            cconn = _conn;
            n_id_room = id_room;
            n_image = image;
            textBox6.Text = numberofseats;
            textBox4.Text = floor;
            textBox2.Text = payment;
            n_id_roomtype = id_roomtype;
            checkBox1.Checked = tv;
            checkBox2.Checked = fridge;

        }

        private void button2_Click(object sender, EventArgs e)
        {
                new Add_Client(info, cconn, id_room).ShowDialog();
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void изменитьДанныеОбАвтошколеToolStripMenuItem_Click(object sender, EventArgs e)
        {
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox6.ReadOnly = false;
                comboBox1.Enabled = true;
                button3.Visible = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText)
            {
                case "Фамилия":
                    id_client = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    surname_client = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    name_client = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    patronymic_client = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    job = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    birthday = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    id_city = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    id_socialstatus = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    adress = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    Hide();
                    new infoclient(cconn, id_client, surname_client, name_client, patronymic_client, job, birthday, id_city, id_socialstatus, adress).ShowDialog();
                    Show();
                    LoadTable();
                    break;
                case "":
                    Notes_SQL = "типы номеров";
                    inforoom_Load();
                    break;

            }
            LoadInfo();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LoadInfo();
        }

        public void LoadInfo() 
        {
            sql_info = ($"SELECT a.id_client AS ID, a.surname_client as Фамилия, a.name_client as Имя, a.patronymic_client as Отчество,t.city as Город, s.socialstatus as Соц_положение, a.adress as Адрес, a.job as Работа, a.birthday as Дата_Рождения From client a left join city t on(t.id_city=a.id_city) left join socialstatus s on(s.id_socialstatus=a.id_socialstatus) ORDER BY ID OFFSET  ((" + (numericUpDown1.Value - 1) + ") * " + 15 + ") " +
  "ROWS FETCH NEXT " + 15 + "ROWS ONLY;");
            InfoDataAdapter = new NpgsqlDataAdapter(sql_info, cconn);
            DataTable dt = new DataTable();
            ds.Reset();
            InfoDataAdapter.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
            
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBox4.Text);
            }
            catch (Exception exp)
            {
                textBox4.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBox2.Text);
            }
            catch (Exception exp)
            {
                textBox2.Clear();
            }
           
        }

        public void roomtype_Load()
        {
            sql_info = ($"SELECT * FROM roomtype");
            NpgsqlDataAdapter reader = new NpgsqlDataAdapter(sql_info, cconn);
            data = new DataTable();
            DataSet ds = new DataSet();
            ds.Reset();
            reader.Fill(ds);
            data = ds.Tables[0];
            comboBox1.DataSource = data;
            comboBox1.ValueMember = "id_roomtype";
            comboBox1.DisplayMember = "roomtype";
        }

        public void LoadTable()
        {
            try
            {
                pictureBox1.Image = Image.FromFile(n_image);
            }
            catch (Exception exp)
            {
                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                string path = Path.Combine(dir, @"default.jpg");
                pictureBox1.Image = Image.FromFile(path);
            }
            LoadInfo();
        }
        public void SortSearch()
        {
            NpgsqlCommand command;
            searchText = Search_SQL.Text;
            if (Search_Type.SelectedItem == null) { MessageBox.Show("Мы что, ничего не ищем?!"); return; }
            switch (Search_Type.SelectedItem)
            {
                case "ID":
                    try
                    {
                        tablecommand = $"select * from search_room({Convert.ToInt32(searchText)},{numericUpDown1.Value - 1})";
                    }
                    catch (Exception ex) { return; }
                    command = new NpgsqlCommand($"SELECT COUNT (*) from room where id_room={searchText}", cconn);
                    CountText.Text = command.ExecuteScalar().ToString();
                    break;
                case "Тип_комнаты":
                    command = new NpgsqlCommand($"Select id_roomtype from roomtype where roomtype LIKE '%{searchText}%'", cconn);
                    SearchSort = Convert.ToInt32(command.ExecuteScalar());
                    tablecommand = $"select * from search_roomtype({SearchSort}, {numericUpDown1.Value - 1})";
                    command = new NpgsqlCommand($"SELECT COUNT (*) from room where id_roomtype = {SearchSort}", cconn);
                    CountText.Text = command.ExecuteScalar().ToString();
                    break;
                case "Колво_кроватей":
                    try
                    {
                        tablecommand = $"select * from search_seats({Convert.ToInt32(searchText)},{numericUpDown1.Value - 1})";
                    }
                    catch (Exception ex) { return; }
                    command = new NpgsqlCommand($"SELECT COUNT (*) from room where numberofseats={searchText}", cconn);
                    SearchSort = Convert.ToInt32(command.ExecuteScalar());
                    CountText.Text = command.ExecuteScalar().ToString();
                    break;
                case "Этаж":
                    try
                    {
                        tablecommand = $"select * from search_floor({Convert.ToInt32(searchText)},{numericUpDown1.Value - 1})";
                    }
                    catch (Exception ex) { return; }
                    command = new NpgsqlCommand($"SELECT COUNT (*) from room where floor={searchText}", cconn);
                    CountText.Text = command.ExecuteScalar().ToString();
                    break;
                case "Размер_оплаты":
                    try
                    {
                        tablecommand = $"select * from search_payment({Convert.ToInt32(searchText)},{numericUpDown1.Value - 1})";
                    }
                    catch (Exception ex) { return; }
                    command = new NpgsqlCommand($"SELECT COUNT (*) from room where payment={searchText}", cconn);
                    CountText.Text = command.ExecuteScalar().ToString();
                    break;
            }
            LoadTable();
        }
        private void inforoom_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
            roomtype_Load();
            pictureBox1.Text = n_image;
            textBox6.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox2.ReadOnly = true;
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedText = n_id_roomtype;
            comboBox1.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            LoadTable();
        }
    }
}

