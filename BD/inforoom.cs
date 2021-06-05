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
        NpgsqlConnection _conn;
        DataSet ds = new DataSet();
        NpgsqlDataAdapter dataAdapter1 = null, InfoDataAdapter;
        DataTable data;
        NpgsqlConnection cconn;
        int id_room, n_id_room, SearchSort;
        string Note_choose,Notes_SQL, id_client, id_roomtype,  n_id_roomtype, surname_client,name_client, patronymic_client, job, id_city,id_socialstatus, adress, image, numberofseats, floor, payment, roomtype, searchText, tablecommand, info, sql_info, n_image, n_numberofseats, n_floor, n_payment;
        DateTime birthday;



        private void button5_Click(object sender, EventArgs e)
        {
                NpgsqlCommand command = new NpgsqlCommand($"UPDATE room SET payment='{textBox2.Text}', floor='{textBox4.Text}', numberofseats='{textBox6.Text}',id_roomtype ={comboBox1.SelectedValue.ToString()}, tv ='{checkBox1.Checked}', fridge= '{checkBox2.Checked}', image ='{n_image}' WHERE id_room={n_id_room}", cconn);
                if (textBox2.Text == "" || textBox4.Text == "" || textBox6.Text == "" || comboBox1.SelectedValue == null) { MessageBox.Show("Поле не может быть пустым"); return; }
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Проверьте введённые данные");
                    return;
                }
            textBox2.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox6.ReadOnly = true;
            comboBox1.Enabled = false;
            button5.Visible = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
        }

        


        public inforoom(NpgsqlConnection _conn, int id_room, string image, string numberofseats, string floor, string payment, string id_roomtype, bool tv, bool fridge, string Notes_SQL)
        {
            Note_choose = Notes_SQL;
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

        private void Search_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CountText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Search_SQL_TextChanged(object sender, EventArgs e)
        {
            LoadInfo();
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
                button5.Visible = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                button4.Visible = true;
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sql_info = ($"SELECT a.id_client AS ID, a.surname_client as Фамилия, a.name_client as Имя, a.patronymic_client as Отчество ,t.city as Город, s.socialstatus as Соц_положение, a.adress as Адрес, a.job as Работа, a.birthday as День_рождения from client a left join city t on (t.id_city = a.id_city) left join socialstatus s on (s.id_socialstatus = a.id_socialstatus) where socialstatus LIKE '%{Search_SQL.Text}%' ");
                InfoDataAdapter = new NpgsqlDataAdapter(sql_info, cconn);
                DataTable dt = new DataTable();
                ds.Reset();
                InfoDataAdapter.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText)
            {
                case "Фамилия":
                    id_client = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    surname_client = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    name_client = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    patronymic_client = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    job = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    birthday = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                    id_city = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    id_socialstatus = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    adress = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    Hide();
                    new infoclient(cconn, id_client, surname_client, name_client, patronymic_client, job, birthday, id_city, id_socialstatus, adress).ShowDialog();
                    Show();
                    LoadTable();
                    break;
            }
            LoadInfo();
        }



        public void LoadInfo() 
        {
            sql_info = ($"SELECT a.id_client AS ID, a.surname_client as Фамилия, a.name_client as Имя, a.patronymic_client as Отчество,t.city as Город, s.socialstatus as Соц_положение, a.adress as Адрес, a.job as Работа, a.birthday as Дата_Рождения From client a left join city t on(t.id_city=a.id_city) left join socialstatus s on(s.id_socialstatus=a.id_socialstatus) where a.id_room = {n_id_room} ORDER BY ID OFFSET  ((" + (numericUpDown1.Value - 1) + ") * " + 15 + ") " +
  "ROWS FETCH NEXT " + 15 + "ROWS ONLY;");

            InfoDataAdapter = new NpgsqlDataAdapter(sql_info, cconn);
            DataTable dt = new DataTable();
            ds.Reset();
            InfoDataAdapter.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LoadInfo();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF";
            dialog.ShowDialog();
            if (dialog.CheckFileExists == true)
            {
                n_image = dialog.FileName;
            }
            else { MessageBox.Show("Вы не выбрали фото!"); }
            pictureBox1.Image = Image.FromFile(n_image);
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
            button5.Visible = false;
            button4.Visible = false; ;
            LoadTable();
        }
    }
}

