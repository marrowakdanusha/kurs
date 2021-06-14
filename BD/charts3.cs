using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;


namespace BD
{
    public partial class charts3 : Form
    {
        NpgsqlConnection connection;
        List<int> list_districts = new List<int>();
        List<int> list_autoschools = new List<int>();
        List<int> list_types_of_property = new List<int>();
        NpgsqlCommand cmd;
        NpgsqlDataReader dr;
        public charts3(NpgsqlConnection _conn)
        {
            connection = _conn;
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void Select_Districts()
        {
            NpgsqlDataAdapter reader;
            cmd = new NpgsqlCommand("SELECT distinct socialstatus FROM socialstatus ORDER BY socialstatus", connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                dr.Close();
                return;
            }
            while (dr.Read())
            {
                chart1.Series.Add(new Series(dr[0].ToString()) { ChartType = SeriesChartType.Column });
                chart1.Series[dr[0].ToString()].IsValueShownAsLabel = true;
                chart1.Series[dr[0].ToString()].Font = new Font("Microsoft Sans Serif", 12);
            }
            dr.Close();
            DataTable data = new DataTable();
            load();

        }
        public void load()
        {
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            NpgsqlDataReader drk;
            cmd = new NpgsqlCommand("select room.id_room , socialstatus.socialstatus, NULLIF(count(*), 0) from client left join room on client.id_room = room.id_room  left join socialstatus on socialstatus.id_socialstatus = client.id_socialstatus GROUP BY room.id_room,  socialstatus.socialstatus ORDER BY room.id_room, count(*) DESC", connection);
            drk = cmd.ExecuteReader();
            if (!drk.HasRows)
            {
                drk.Close();
                return;
            }

            while (drk.Read())
            {
                if (drk[1].ToString() != "")
                    chart1.Series[drk[1].ToString()].Points.AddXY(drk[0].ToString(), drk[2].ToString());
                else
                    chart1.Series[0].Points.AddXY(drk[0].ToString(), 0);
            }
            chart1.Legends[0].Font = new Font("Microsoft Sans Serif", 12);

            drk.Close();
        }

        private void charts3_Load_1(object sender, EventArgs e)
        {
            Select_Districts();
        }
    }
}