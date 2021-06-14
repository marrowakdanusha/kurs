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
            NpgsqlDataAdapter command = new NpgsqlDataAdapter($"select first_sel.roomtype, (float4 (count_bad * 100) / float4((SELECT count(*) FROM room ))) AS Процент FROM(SELECT roomtype.roomtype, count(*) AS count_bad FROM room LEFT JOIN  roomtype on roomtype.id_roomtype = room.id_roomtype WHERE(room.numberofseats > 5) GROUP BY roomtype.roomtype ORDER BY roomtype.roomtype) AS first_sel ", connection);
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
