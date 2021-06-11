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
    /// 
    /// ЗАПРОС С ПОДЗАПРОСОМ
    /// 
    public partial class Individ : Form
    {
        NpgsqlConnection connection;
        NpgsqlDataAdapter command;
        public Individ(NpgsqlConnection _conn)
        {
            connection = _conn;
            InitializeComponent();
        }     private void Individ_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "Королевский")
            {
                command = new NpgsqlDataAdapter("" +
                  "SELECT roomtype.roomtype,sel.count FROM roomtype,(SELECT room.id_roomtype,count(*) " +
                  "FROM room GROUP BY room.id_roomtype) as sel WHERE roomtype.id_roomtype=sel.id_roomtype AND roomtype.id_roomtype = '20'", connection);
            }
            else if (comboBox1.SelectedItem.ToString() == "Комфорт")
            {
                command = new NpgsqlDataAdapter("" +
                "SELECT roomtype.roomtype,sel.count FROM roomtype,(SELECT room.id_roomtype,count(*) " +
                  "FROM room GROUP BY room.id_roomtype) as sel WHERE roomtype.id_roomtype=sel.id_roomtype AND roomtype.id_roomtype =  '11'", connection);
            }
            else if (comboBox1.SelectedItem.ToString() == "Эконом")
            {
                command = new NpgsqlDataAdapter("" +
                "SSELECT roomtype.roomtype,sel.count FROM roomtype,(SELECT room.id_roomtype,count(*) " +
                  "FROM room GROUP BY room.id_roomtype) as sel WHERE roomtype.id_roomtype=sel.id_roomtype AND roomtype.id_roomtype = '12'", connection);
            }
            else if (comboBox1.SelectedItem.ToString() == "Дэлюкс")
            {
                command = new NpgsqlDataAdapter("" +
                "SELECT roomtype.roomtype,sel.count FROM roomtype,(SELECT room.id_roomtype,count(*) " +
                  "FROM room GROUP BY room.id_roomtype) as sel WHERE roomtype.id_roomtype=sel.id_roomtype AND roomtype.id_roomtype = '13'", connection);
            }
            else if (comboBox1.SelectedItem.ToString() == "Угловой номер")
            {
                command = new NpgsqlDataAdapter("" +
                "SELECT roomtype.roomtype,sel.count FROM roomtype,(SELECT room.id_roomtype,count(*) " +
                  "FROM room GROUP BY room.id_roomtype) as sel WHERE roomtype.id_roomtype=sel.id_roomtype AND roomtype.id_roomtype =  '14'", connection);
            }
            else if (comboBox1.SelectedItem.ToString() == "Бизнесс")
            {
                command = new NpgsqlDataAdapter("" +
                "SELECT roomtype.roomtype,sel.count FROM roomtype,(SELECT room.id_roomtype,count(*) " +
                  "FROM room GROUP BY room.id_roomtype) as sel WHERE roomtype.id_roomtype=sel.id_roomtype AND roomtype.id_roomtype =  '16'", connection);
            }
            else if (comboBox1.SelectedItem.ToString() == "Семейный")
            {
                command = new NpgsqlDataAdapter("" +
                "SELECT roomtype.roomtype,sel.count FROM roomtype,(SELECT room.id_roomtype,count(*) " +
                  "FROM room GROUP BY room.id_roomtype) as sel WHERE roomtype.id_roomtype=sel.id_roomtype AND roomtype.id_roomtype = '17'", connection);
            }
            else if (comboBox1.SelectedItem.ToString() == "Люкс")
            {
                command = new NpgsqlDataAdapter("" +
                "SELECT roomtype.roomtype,sel.count FROM roomtype,(SELECT room.id_roomtype,count(*) " +
                  "FROM room GROUP BY room.id_roomtype) as sel WHERE roomtype.id_roomtype=sel.id_roomtype AND roomtype.id_roomtype = '19'", connection);
            }

            DataTable dt = new DataTable();
            DataSet ds = new DataSet(); 
            ds.Reset();
            command.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
