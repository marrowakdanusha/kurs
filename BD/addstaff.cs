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
    public partial class addstaff : Form
    {
        string surname, name, patronymic;

        DataTable data;
        NpgsqlConnection _conn;
        public addstaff(NpgsqlConnection __conn)
        {
            _conn = __conn;
            InitializeComponent();
        }

        private void addstaff_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            surname = textBox1.Text;
        }

        public void Load_DataTable(string command)
        {
            NpgsqlDataAdapter reader = new NpgsqlDataAdapter(command, _conn);
            data = new DataTable();
            DataSet ds = new DataSet();
            ds.Reset();
            reader.Fill(ds);
            data = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Введите фамилию сотрудника"); return; }
            if (textBox2.Text == "") { MessageBox.Show("Введите имя сотрудника"); return; }
            if (textBox3.Text == "") { MessageBox.Show("Введите отчество сотрудника"); return; }
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                NpgsqlCommand addcommand = new NpgsqlCommand($"INSERT INTO staff(staff_surname, staff_name, staff_patronymic) VALUES('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}')", _conn);
            try
                {
                    addcommand.ExecuteNonQuery();
                    Close();
                }
            catch(Exception ee)
                {
                    MessageBox.Show("Проверьте введёные данные");
                }
             }
            else 
            {
                MessageBox.Show("Название не введено!");
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            patronymic = textBox3.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            name = textBox2.Text;
        }

    }
}
