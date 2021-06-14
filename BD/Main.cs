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
using BD;

namespace BD
{
    public partial class Main : Form
    {
        string id_roomtype, image, numberofseats, floor, payment, roomtype, searchText, tablecommand, info;
        int id_room, page_number = 1;
        bool tv, fridge;
        int SearchSort;
        string Update_ID = "ALTER SEQUENCE room_id_room_seq RESTART WITH 1" + ";" +
        "UPDATE room SET id_room = DEFAULT";
        NpgsqlConnection _conn;
        DataSet ds = new DataSet();
        NpgsqlDataAdapter dataAdapter1 = null;
        string Notes_SQL;
        
        public Main(NpgsqlConnection conn)
        {
            _conn = conn;
            InitializeComponent();
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсач студента второго курса группы ПИ-19Б, Чумарина Даниила \n" +
              "предназначен для работы с базами данных отелей.");
        }

        private void типНомераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes_SQL = "типы номеров";
            Notes_Load();
        }

        private void допУслугаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes_SQL = "Дополнительные услуги";
            Notes_Load();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Hide(); new Addroom(info, _conn, id_room).ShowDialog();
            LoadTable(); Show();
        }

        private void квитанцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Notes_SQL = "квитанции";
                Notes_Load();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes_SQL = "клиенты";
            Notes_Load();
        }

        private void городToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes_SQL = "города";
            Notes_Load();
        }
        public void LoadTable()
        {
            if (Search_SQL.Text == "")
            {
                tablecommand = "SELECT a.id_room AS ID, a.image AS Фотография,r.roomtype AS Тип_комнаты, a.numberofseats AS Колво_кроватей, a.floor AS Этаж, a.payment AS Размер_оплаты, a.tv AS Телевизор, a.fridge AS Холодильник from room a left join roomtype r on(r.id_roomtype = a.id_roomtype) ORDER BY Id OFFSET ((" + (numericCountSQL.Value - 1) + ") * " + 15 + ") " +
    "ROWS FETCH NEXT " + 15 + "ROWS ONLY;";
                NpgsqlCommand id_room = new NpgsqlCommand("SELECT COUNT(*) FROM room", _conn);
                CountText.Text = id_room.ExecuteScalar().ToString();
            }
            dataAdapter1 = new NpgsqlDataAdapter(tablecommand, _conn);
            DataTable dt = new DataTable();
            ds.Reset();
            dataAdapter1.Fill(ds);
            dt = ds.Tables[0];
            Room_table.DataSource = dt;
            numericCountSQL.Maximum = (Convert.ToInt32(CountText.Text) / 15) + 1;
        }
        private void Del_Button_Click(object sender, EventArgs e)
        {

            {
                NpgsqlCommand countdel1;
                DialogResult result = new DialogResult();
                string deleteRowSQL = "";
                if (Del_Type.SelectedItem != null)
                {
                    if (Del_Type.SelectedItem.ToString() == "Одну строку")
                    {
                        if (Room_table.Rows.Count > 1)
                        {
                            deleteRowSQL = $" DELETE FROM room WHERE id_room={Room_table.CurrentRow.Cells[0].Value}";
                            NpgsqlCommand deleteCommand = new NpgsqlCommand(deleteRowSQL, _conn);
                            deleteCommand.ExecuteNonQuery();
                            LoadTable();
                        }
                        else
                        {
                            MessageBox.Show("Таблица пустая!");
                        }

                    }
                    if (Del_Type.SelectedItem.ToString() == "Все поля")
                    {
                        if (Search_SQL.Text != "")
                        {
                            switch (Search_Type.SelectedItem.ToString())
                            {
                                case "Фотография": deleteRowSQL = $" DELETE FROM room where image={SearchSort}"; break;
                                case "Тип_комнаты": deleteRowSQL = $" DELETE FROM room where id_roomtype={SearchSort}"; break;
                                case "Колво_кроватей": deleteRowSQL = $" DELETE FROM room where numberofseats='{Search_SQL.Text}'"; break;
                                case "Этаж": deleteRowSQL = $" DELETE FROM room where floor='{Search_SQL.Text}'"; break;
                                case "Размер_оплаты": deleteRowSQL = $" DELETE FROM room where payment='{Search_SQL.Text}'"; break;
                            }
                            NpgsqlCommand deleteCommand = new NpgsqlCommand(deleteRowSQL, _conn);
                            deleteCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            deleteRowSQL = $" DELETE FROM room";
                            NpgsqlCommand deleteCommand = new NpgsqlCommand(deleteRowSQL, _conn);

                            deleteCommand.ExecuteNonQuery();
                            NpgsqlCommand updateCommand = new NpgsqlCommand(Update_ID, _conn);
                            updateCommand.ExecuteNonQuery();
                        }
                        LoadTable();
                    }
                }
                else { MessageBox.Show("Выберите метод удаления записей в БД!"); }
            }
        }

        private void numericCountSQL_ValueChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (Room_table.Columns[Room_table.CurrentCell.ColumnIndex].HeaderText)
            {
                case "Фотография":
                    id_room = Convert.ToInt32(Room_table.CurrentRow.Cells[0].Value);
                    image = Room_table.CurrentRow.Cells[1].Value.ToString();
                    id_roomtype = Room_table.CurrentRow.Cells[2].Value.ToString();
                    numberofseats = Room_table.CurrentRow.Cells[3].Value.ToString();
                    floor = Room_table.CurrentRow.Cells[4].Value.ToString();
                    payment = Room_table.CurrentRow.Cells[5].Value.ToString();
                    tv = Convert.ToBoolean(Room_table.CurrentRow.Cells[6].Value);
                    fridge = Convert.ToBoolean(Room_table.CurrentRow.Cells[7].Value);
                    Hide();
                    new inforoom(_conn, image, numberofseats, floor, payment, id_roomtype, tv, fridge, id_room).ShowDialog();
                    Show();
                    LoadTable();
                    break;
                

            }
        }

        private void Del_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SortSearch()
        {
            NpgsqlCommand command;
            searchText = Search_SQL.Text;

            if (Search_Type.SelectedItem == null) { MessageBox.Show("Мы что, ничего не ищем?!"); return; }
            switch (Search_Type.SelectedItem)
            {
                case "ID":
                    try
                    {
                        tablecommand = $"select * from search_room({Convert.ToInt32(searchText)},{numericCountSQL.Value - 1})";
                    }
                    catch (Exception ex) {  return; }
                    command = new NpgsqlCommand($"SELECT COUNT (*) from room where id_room={searchText}", _conn);
                    CountText.Text = command.ExecuteScalar().ToString();
                    break;
                case "Тип_комнаты":
                    command = new NpgsqlCommand($"Select id_roomtype from roomtype where roomtype LIKE '%{searchText}%'", _conn);
                    SearchSort = Convert.ToInt32(command.ExecuteScalar());
                    tablecommand = $"select * from search_roomtype({SearchSort}, {numericCountSQL.Value - 1})";
                    command = new NpgsqlCommand($"SELECT COUNT (*) from room where id_roomtype = {SearchSort}", _conn);
                    CountText.Text = command.ExecuteScalar().ToString();
                    break;
                case "Колво_кроватей":
                try
                {
                    tablecommand = $"select * from search_seats({Convert.ToInt32(searchText)},{numericCountSQL.Value - 1})";
                }
                catch (Exception ex) {return; }
                command = new NpgsqlCommand($"SELECT COUNT (*) from room where numberofseats={searchText}", _conn);
                SearchSort = Convert.ToInt32(command.ExecuteScalar());
                CountText.Text = command.ExecuteScalar().ToString();
                break;
                case "Этаж":
                    try
                    {
                        tablecommand = $"select * from search_floor({Convert.ToInt32(searchText)},{numericCountSQL.Value - 1})";
                    }
                    catch (Exception ex) { return; }
                    command = new NpgsqlCommand($"SELECT COUNT (*) from room where floor={searchText}", _conn);
                    CountText.Text = command.ExecuteScalar().ToString();
                    break;
                case "Размер_оплаты":
                    try
                    {
                        tablecommand = $"select * from search_payment({Convert.ToInt32(searchText)},{numericCountSQL.Value - 1})";
                    }
                    catch (Exception ex) { return; }
                    command = new NpgsqlCommand($"SELECT COUNT (*) from room where payment={searchText}", _conn);
                    CountText.Text = command.ExecuteScalar().ToString();
                    break;
            }
            LoadTable();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CountText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { SortSearch(); }
        }

        private void Searchlable_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void номераИКлиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablecommand = ("SELECT distinct room.id_room, (select count(*) from client where client.id_room = room.id_room) from room left join client c on c.id_room = room.id_room");
            dataAdapter1 = new NpgsqlDataAdapter(tablecommand, _conn);
            DataTable dt = new DataTable();
            ds.Reset();
            dataAdapter1.Fill(ds);
            dt = ds.Tables[0];
            Room_table.DataSource = dt;
        }

        private void отборНомеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablecommand = ("SELECT room.id_room, room.payment from room where room.payment > (SELECT sum(payment) / count (id_room) from room)");
            dataAdapter1 = new NpgsqlDataAdapter(tablecommand, _conn);
            DataTable dt = new DataTable();
            ds.Reset();
            dataAdapter1.Fill(ds);
            dt = ds.Tables[0];
            Room_table.DataSource = dt;
        }

        private void вывестиКолвоНомеровСТакимтоТипомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Individ(_conn).ShowDialog();
            Show();
        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void прибыльЗаУказанныйГодВЗависимостиОтТипаНомераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new inforeceipt(_conn).ShowDialog();
            Show();
        }

        private void типНомераПользующийсяМаксСпросомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new maxspros(_conn).ShowDialog();
            Show();
        }

        private void подсчётСуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new moneymaker(_conn).ShowDialog();
            Show();
        }

        private void круговаяДиаграммаТиповНомеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new charts1(_conn).ShowDialog();
            Show();
        }

        private void Search_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Search_SQL_TextChanged(object sender, EventArgs e)
        {
            SortSearch();
        }

        private void стафферToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes_SQL = "стафферы";
            Notes_Load();
        }

        private void соцПоложениеКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes_SQL = "соц. положения клиентов";
            Notes_Load();
        }

        private void странаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes_SQL = "страны";
            Notes_Load();
        }
        public void Notes_Load()
        {
            Hide();
            new Notes(_conn, Notes_SQL).ShowDialog();
            Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            numericCountSQL.Minimum = 1;
            LoadTable(); 
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (Search_SQL.Text != "") { SortSearch(); }
            else
            {
                LoadTable();
            }
        }

        
    
      
    }
}

