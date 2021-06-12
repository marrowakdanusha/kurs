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
    public partial class fullreceipt : Form
    {
        DataTable data;
        NpgsqlConnection connection;
        NpgsqlCommand command, Add_command;
        string command_Add, aim, id_client;
        int day, month, year, day1, month1, year1, n1_id_room;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public fullreceipt(NpgsqlConnection __conn, int id_room1, string n_id_client)
        {
            connection = __conn;
            n1_id_room = id_room1;
            id_client = n_id_client;
            InitializeComponent();
        }

        private void fullreceipt_Load(object sender, EventArgs e)
        {
            string command1 = $"SELECT id_room FROM room where id_room = {n1_id_room}";
            NpgsqlCommand acommand = new NpgsqlCommand(command1, connection);
            comboBox2.Text = acommand.ExecuteScalar().ToString();
            comboBox2.Enabled = false;

            string command2 = $"SELECT surname_client FROM client where id_client = {id_client}";
            NpgsqlCommand bcommand = new NpgsqlCommand(command2, connection);
            comboBox1.Text = bcommand.ExecuteScalar().ToString();
            comboBox1.Enabled = false;

            staff_Load();
            extraservice_Load();
        }

        private void staff_Load()
        {
            string command = "SELECT * FROM staff";
            Load_DataTable(command);
            comboBox3.DataSource = data;
            comboBox3.ValueMember = "id_staff";
            comboBox3.DisplayMember = "staff_surname";
        }
        private void extraservice_Load()
        {
            string command = "SELECT * FROM extraservice";
            Load_DataTable(command);
            comboBox4.DataSource = data;
            comboBox4.ValueMember = "id_extraservice";
            comboBox4.DisplayMember = "service";
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

    }
}
