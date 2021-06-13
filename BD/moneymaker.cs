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
