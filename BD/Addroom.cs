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
    public partial class Addroom : Form
    {
        string Choose, command_Add;
        NpgsqlConnection connection;
        NpgsqlCommand Add_command;
        int id_autoschool, id_student;
        DataTable data;
        public Addroom(string info, NpgsqlConnection _conn, int id_room)
        {
            id_autoschool = id_room;
            connection = _conn;
            Choose = info;
            InitializeComponent();
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void Addroom_Load(object sender, EventArgs e)
        {

            roomtype_Load();
        }

        private void roomtype_Load()
        {

            string command = $"SELECT * FROM roomtype";
            Load_DataTable(command);
            comboBox1.DataSource = data;
            comboBox1.ValueMember = "id_roomtype";
            comboBox1.DisplayMember = "roomtype";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Введите кол-во мест в номере"); return; }
            if (textBox2.Text == "") { MessageBox.Show("Введите этаж"); return; }
            if (textBox3.Text == "") { MessageBox.Show("Введите размер оплаты"); return; }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedItem == null) { MessageBox.Show("Не записаны все поля!!!"); return; }
            MessageBox.Show("Теперь нужно выбрать фотографию для нашего номера");
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            dialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF";
            if (dialog.CheckFileExists == false)
            {
                MessageBox.Show("Указан несуществующий файл");
            }
            command_Add = ($"INSERT INTO room(image, id_roomtype, numberofseats, floor, payment, tv, fridge) VALUES('{dialog.FileName}',{Convert.ToInt32(comboBox1.SelectedValue.ToString())},'{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{checkBox1.Checked}','{checkBox2.Checked}') RETURNING id_room");
            Add_command = new NpgsqlCommand(command_Add, connection);
            try
            {
                id_student = Convert.ToInt32(Add_command.ExecuteScalar());
            }
            catch (Exception ee)
            {

                MessageBox.Show("Проверьте что вы ввели все данные");
                return;
            }
            Hide();
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBox1.Text);
            }
            catch (Exception exp)
            {
                textBox1.Clear();
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

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
    }
}
