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
using BD;


namespace BD
{
    public partial class inforeceipt : Form
    {
        NpgsqlConnection connection;
        DataSet ds = new DataSet();
        DataTable data;
        NpgsqlDataAdapter InfoDataAdapter, dataAdapter1 = null;
        string sql_info, command;

        public inforeceipt(NpgsqlConnection _conn)
        {
            connection = _conn;
            InitializeComponent();
        }

        private void Room_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void roomtype_Load()
        {
            sql_info = ($"SELECT * FROM roomtype");
            NpgsqlDataAdapter reader = new NpgsqlDataAdapter(sql_info, connection);
            data = new DataTable();
            DataSet ds = new DataSet();
            ds.Reset();
            reader.Fill(ds);
            data = ds.Tables[0];
            comboBox3.DataSource = data;
            comboBox3.ValueMember = "id_roomtype";
            comboBox3.DisplayMember = "roomtype";
        }

        private void inforeceipt_Load(object sender, EventArgs e)
        {
            roomtype_Load();
        }
        

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = $"Select room.id_room,(reservation.departure_date - reservation.checkin_date) from reservation left join room on (reservation.id_room = room.id_room) left join roomtype on (room.id_roomtype = roomtype.id_roomtype) where roomtype.id_roomtype = {comboBox3.SelectedValue} and fridge = '{checkBox1.Checked}' and tv = '{checkBox2.Checked}'";

            InfoDataAdapter = new NpgsqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            ds.Reset();
            InfoDataAdapter.Fill(ds);
            dt = ds.Tables[0];
            Room_table.DataSource = dt;
        }
    }
}
