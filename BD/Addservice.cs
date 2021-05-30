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
    public partial class Addservice : Form
    {
        string title, raider;


        DataTable data;
        NpgsqlConnection _conn;
        public Addservice(NpgsqlConnection __conn)
        {
            _conn = __conn;
            InitializeComponent();
        }

        private void Addservice_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            title = textBox1.Text;
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
            raider = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Введите название услуги"); return; }
            if (textBox2.Text == "") { MessageBox.Show("Введите стоимость услуги"); return; }
            if (textBox3.Text == "") { MessageBox.Show("Введите пункты райдера"); return; }
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {

                if (Convert.ToInt32(textBox2.Text) < 0) { MessageBox.Show("Стоимость не может быть меньше 0!Повторите ввод"); return; }
                NpgsqlCommand addcommand = new NpgsqlCommand($"INSERT INTO extraservice(service, cost, raider) VALUES('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}')", _conn);
                try
                {
                    addcommand.ExecuteNonQuery();
                    Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Проверьте введёные данные");
                }
            }
            else
            {
                MessageBox.Show("Название не введено!");
            }
        }
    }
}
