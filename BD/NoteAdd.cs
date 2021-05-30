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
    public partial class NoteAdd : Form
    {
        string NoteAdd_Choose;
        NpgsqlConnection connection;
        NpgsqlCommand addCommand;
        public NoteAdd(string Note_choose, NpgsqlConnection __conn)
        {

            connection = __conn;
            NoteAdd_Choose = Note_choose;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoteAdd_Load(object sender, EventArgs e)
        {
            textBox2.Text = NoteAdd_Choose;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                switch (NoteAdd_Choose)
                {

                    case "типы номеров":
                        addCommand = new NpgsqlCommand($"INSERT INTO roomtype(roomtype) VALUES ('{textBox1.Text}')", connection); break;
                    case "города":
                        addCommand = new NpgsqlCommand($"INSERT INTO city(city) VALUES ('{textBox1.Text}')", connection); break;
                    case "соц. положения клиентов":
                        addCommand = new NpgsqlCommand($"INSERT INTO socialstatus(socialstatus) VALUES ('{textBox1.Text}')", connection); break;
                    case "страны":
                        addCommand = new NpgsqlCommand($"INSERT INTO country(country) VALUES ('{textBox1.Text}')", connection); break;
                }

                try
                {
                    addCommand.ExecuteNonQuery();
                    Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Вы не ввели наименование элемента");
                }
            }
            else { MessageBox.Show("Наименование не введено!"); }
        }
    }
}
