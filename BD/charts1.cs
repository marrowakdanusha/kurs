using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;


namespace BD
{
    public partial class charts1 : Form
    {
        NpgsqlConnection connection;

        public charts1(NpgsqlConnection _conn)
        {
            connection = _conn;
            InitializeComponent();
        }

        private void charts1_Load(object sender, EventArgs e)
        {
            NpgsqlDataAdapter command = new NpgsqlDataAdapter($"SELECT roomtype.roomtype,sel.count FROM roomtype,(SELECT room.id_roomtype,count(*) FROM room GROUP BY room.id_roomtype) as sel WHERE roomtype.id_roomtype=sel.id_roomtype", connection);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet(); ds.Reset();
            command.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            List<float> list_counts = new List<float>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                list_counts.Add((float)ds.Tables[0].Rows[i][1]);
                chart1.Series[0].Points.AddY(list_counts[i]);
                chart1.Series[0].Points[i].LegendText = ds.Tables[0].Rows[i][0].ToString();
            }
            /**/
        }
    }
}
