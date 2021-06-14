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
    public partial class charts2 : Form
    {
        NpgsqlConnection connection;

        public charts2(NpgsqlConnection _conn)
        {
            connection = _conn;
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void charts2_Load(object sender, EventArgs e)
        {
            NpgsqlDataAdapter command = new NpgsqlDataAdapter("SELECT roomtype.roomtype, avg(orders_vd) from roomtype LEFT JOIN(SELECT room.id_roomtype as roomtype, count (*) as orders_vd from reservation left join room on room.id_room = reservation.id_room GROUP BY room.id_room ORDER BY room.id_room) as COL on roomtype.id_roomtype = COL.roomtype GROUP BY roomtype.roomtype ORDER BY roomtype.roomtype", connection);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet(); ds.Reset();
            command.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            List<decimal> list_counts = new List<decimal>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][1].ToString() == "") { list_counts.Add(0); }
                else { list_counts.Add((decimal)ds.Tables[0].Rows[i][1]); }
                chart1.Series[0].Points.AddY(list_counts[i]);
                chart1.Series[0].Points[i].LegendText = ds.Tables[0].Rows[i][0].ToString();
            }
        }
    }
}
