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
    public partial class moneymaker : Form
    {
        NpgsqlConnection connection;
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataTable data;
        NpgsqlDataAdapter InfoDataAdapter, dataAdapter1 = null, InfoDataAdapter1;
        string sql_info, command, command1;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomtype_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = $"select room.id_room as Номер, ((room.payment + extraservice.cost) * (reservation.departure_date - reservation.checkin_date)) as К_Оплате from reservation left join room on (reservation.id_room = room.id_room) left join extraservice on (reservation.id_extraservice = extraservice.id_extraservice) left join roomtype on (room.id_roomtype = roomtype.id_roomtype) where roomtype.id_roomtype = {comboBox3.SelectedValue} and EXTRACT (YEAR from departure_date) = '{dateTimePicker1.Value.Year}'";
            InfoDataAdapter = new NpgsqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            ds.Reset();
            InfoDataAdapter.Fill(ds);
            dt = ds.Tables[0];
            Room_table.DataSource = dt;

            command1 = $"select sum ((room.payment + extraservice.cost) * (reservation.departure_date - reservation.checkin_date)) from reservation left join room on (reservation.id_room = room.id_room) left join extraservice on (reservation.id_extraservice = extraservice.id_extraservice) left join roomtype on( room.id_roomtype = roomtype.id_roomtype) where roomtype.id_roomtype = {comboBox3.SelectedValue} and EXTRACT (YEAR from departure_date) = '{dateTimePicker1.Value.Year}'";

            InfoDataAdapter1 = new NpgsqlDataAdapter(command1, connection);
            DataTable dt1 = new DataTable();
            ds1.Reset();
            InfoDataAdapter1.Fill(ds1);
            dt1 = ds1.Tables[0];
            dataGridView1.DataSource = dt1;
        }

        private void Room_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public moneymaker(NpgsqlConnection _conn)
        {
            connection = _conn;
            InitializeComponent();
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

        private void moneymaker_Load(object sender, EventArgs e)
        {
            roomtype_Load();
        }
    }
}
