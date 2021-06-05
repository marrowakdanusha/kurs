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
    public partial class Notes : Form
    {
        NpgsqlConnection __conn;
        string Note_choose, sql;
        string deleteRowSQL, Update_ID;
        int id_room = 0, id_student;
        public Notes(NpgsqlConnection _conn, string Notes_SQL)
        {
            Note_choose = Notes_SQL;
            __conn = _conn;
            InitializeComponent();
        }
        
        private void Notes_Load(object sender, EventArgs e)
        {
            LoadNotes();
            Count_Load();
        }
        public void LoadNotes()
        {
            if (Note_choose == "типы номеров") sql = ("SELECT id_roomtype AS ID,roomtype AS Тип_номера From roomtype ORDER BY ID OFFSET ((" + (numeric_Notes.Value - 1) + ") * " + 15 + ") " +
  "ROWS FETCH NEXT " + 15 + "ROWS ONLY;");
           else if (Note_choose == "Дополнительные услуги") sql = ("SELECT id_extraservice AS ID,service AS Доп_услуги, cost AS Стоимость_услуги, raider AS пункты_райдера From extraservice ORDER BY ID OFFSET ((" + (numeric_Notes.Value - 1) + ") * " + 15 + ") " +
  "ROWS FETCH NEXT " + 15 + "ROWS ONLY;");
            else if (Note_choose == "стафферы") sql = ("SELECT id_staff AS ID,staff_name AS Имя, staff_surname AS Фамилия, staff_patronymic AS Отчество From staff ORDER BY ID OFFSET ((" + (numeric_Notes.Value - 1) + ") * " + 15 + ") " +
  "ROWS FETCH NEXT " + 15 + "ROWS ONLY;");
            else if (Note_choose == "соц. положения клиентов") sql = ("SELECT id_socialstatus AS ID, socialstatus as Социальное_положение From socialstatus ORDER BY ID OFFSET ((" + (numeric_Notes.Value - 1) + ") * " + 15 + ") " +
  "ROWS FETCH NEXT " + 15 + "ROWS ONLY;");
            else if (Note_choose == "страны") sql = ("SELECT id_country AS ID, country as Страна From country ORDER BY ID OFFSET ((" + (numeric_Notes.Value - 1) + ") * " + 15 + ") " +
  "ROWS FETCH NEXT " + 15 + "ROWS ONLY;");
            else if (Note_choose == "квитанции") sql = ("SELECT a.id_receipt AS ID, a.checkin_date as Дата_заселения, a.departure_date as Дата_выезда, a.payment_incash as Оплата_Наличкой, a.book as Бронирование, a.aim as Цель_приезда, p.surname_client as Фамилия_клиента, s.service as Доп_услуги, c.id_room as Номер_комнаты, j.staff_surname From reservation a left join client p on(p.id_client = a.id_client) left join extraservice s on (s.id_extraservice = a.id_extraservice) left join room c on (c.id_room = a.id_room) left join staff j on (j.id_staff= a.id_staff) ORDER BY ID OFFSET ((" + (numeric_Notes.Value - 1) + ") * " + 15 + ") " +
  "ROWS FETCH NEXT " + 15 + "ROWS ONLY;");
            else if (Note_choose == "клиенты") sql = ("SELECT a.id_client AS ID, a.surname_client as Фамилия, a.name_client as Имя, a.patronymic_client as Отчество,t.city as Город, s.socialstatus as Соц_положение, a.adress as Адрес, a.job as Работа, a.birthday as Дата_Рождения From client a left join city t on(t.id_city=a.id_city) left join socialstatus s on(s.id_socialstatus=a.id_socialstatus) ORDER BY ID OFFSET  ((" + (numeric_Notes.Value - 1) + ") * " + 15 + ") " +
  "ROWS FETCH NEXT " + 15 + "ROWS ONLY;");
            else if (Note_choose == "города") sql = ("SELECT a.id_city AS ID, a.city as Город, c.country as Страна From city a left join country c on(c.id_country=a.id_country) ORDER BY ID OFFSET ((" + (numeric_Notes.Value - 1) + ") * " + 15 + ") " +
  "ROWS FETCH NEXT " + 15 + "ROWS ONLY;");

            LoadTable();
        }
        public void LoadTable()
        {
            DataSet ds = new DataSet();
            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sql, __conn);
            DataTable dt = new DataTable();
            ds.Reset();
            dataAdapter1.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
       

     

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void типНомераToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Note_choose = "типы номеров";
            LoadNotes();
            Count_Load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Note_choose == "типы номеров" || Note_choose == "соц. положения клиентов" ||
               Note_choose == "страны")
            {
                Hide();
                new NoteAdd (Note_choose, __conn).ShowDialog();
                Show();
            }
             else if ( Note_choose == "Дополнительные услуги") { Hide(); new Addservice(__conn).ShowDialog(); Show(); }
             else if (Note_choose == "стафферы") { Hide(); new addstaff(__conn).ShowDialog(); Show(); }
          //  else if (Note_choose == "клиенты") { Hide(); new Add_Client(__conn).ShowDialog(); Show(); }
            else if (Note_choose == "квитанции") { Hide(); new Addreceipt(__conn).ShowDialog(); Show(); }
            else if (Note_choose == "города") { Hide(); new addcity(__conn).ShowDialog(); Show(); }

            LoadNotes();
            Count_Load();
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void допУслугаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Note_choose = "Дополнительные услуги";
            LoadNotes();
            Count_Load();
        }

        private void квитанцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note_choose = "квитанции";
            LoadNotes();
            Count_Load();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note_choose = "клиенты";
            LoadNotes();
            Count_Load();
        }

        private void городаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note_choose = "города";
            LoadNotes();
            Count_Load();
        }

        private void стафферToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Note_choose = "стафферы";
            LoadNotes();
            Count_Load();
        }

        private void numeric_Notes_ValueChanged(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                NpgsqlCommand countdel1;
                string count = "";
                DialogResult result = new DialogResult();
                if (comboBox1.SelectedItem != null)
                {
                    if (comboBox1.SelectedItem.ToString() == "Одну строку")
                    {
                        if (dataGridView1.Rows.Count > 1)
                        {
                            switch (Note_choose)
                            {
                                //комната зависит
                                case "типы номеров":
                                    deleteRowSQL = $" DELETE FROM roomtype WHERE id_roomtype={dataGridView1.CurrentRow.Cells[0].Value}";
                                    count = $"Select Count(*) from room where id_roomtype={dataGridView1.CurrentRow.Cells[0].Value}";
                                    countdel1 = new NpgsqlCommand(count, __conn);
                                    result = MessageBox.Show($"При удалении будет удалено {countdel1.ExecuteScalar()} номеров.",
                                        "Выберите один из вариантов.", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); break;
                                //комната зависит
                                case "Дополнительные услуги":
                                    deleteRowSQL = $" DELETE FROM extraservice WHERE id_extraservice={dataGridView1.CurrentRow.Cells[0].Value}";
                                    count = $"Select Count(*) from service where id_extraservice={dataGridView1.CurrentRow.Cells[0].Value}";
                                    countdel1 = new NpgsqlCommand(count, __conn);
                                    result = MessageBox.Show($"При удалении будет удалено {countdel1.ExecuteScalar()} номеров.",
                                        "Выберите один из вариантов", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); break;
                                //nikto ne zavisit
                                case "стафферы":
                                    deleteRowSQL = $" DELETE FROM staff WHERE id_staff={dataGridView1.CurrentRow.Cells[0].Value}";
                                    break;
                                //client зависит
                                case "соц. положения клиентов":
                                    deleteRowSQL = $" DELETE FROM socialstatus WHERE id_socialstatus={dataGridView1.CurrentRow.Cells[0].Value}";
                                    count = $"Select Count(*) from client where id_socialstatus={dataGridView1.CurrentRow.Cells[0].Value}";
                                    countdel1 = new NpgsqlCommand(count, __conn);
                                     result = MessageBox.Show($"При удалении будет удалено {countdel1.ExecuteScalar()} клиентов.",
                                        "Выберите один из вариантов", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); break;
                                //города зависят
                                case "страны":
                                    deleteRowSQL = $" DELETE FROM country WHERE id_country={dataGridView1.CurrentRow.Cells[0].Value}";
                                    count = $"Select Count(*) from city where id_country={dataGridView1.CurrentRow.Cells[0].Value}";
                                    countdel1 = new NpgsqlCommand(count, __conn);
                                    result = MessageBox.Show($"При удалении будет удалено {countdel1.ExecuteScalar()} городов.",
                                     "Выберите один из вариантов.", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                     MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); break;
                                //ne зависят
                                case "квитанции":
                                    deleteRowSQL = $" DELETE FROM receipt WHERE id_receipt={dataGridView1.CurrentRow.Cells[0].Value}";
                                     break;
                                //квитанция зависят
                                case "клиенты":
                                    deleteRowSQL = $" DELETE FROM client WHERE id_client={dataGridView1.CurrentRow.Cells[0].Value}";
                                    count = $"Select Count(*) from reservation where id_client={dataGridView1.CurrentRow.Cells[0].Value}";
                                    countdel1 = new NpgsqlCommand(count, __conn);
                                    result = MessageBox.Show($"При удалении будет удалено {countdel1.ExecuteScalar()} квитанций.",
                                     "Выберите один из вариантов.", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                     MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); break;
                                //клиенты зависят
                                case "города":
                                    deleteRowSQL = $" DELETE FROM city WHERE id_city={dataGridView1.CurrentRow.Cells[0].Value}";
                                    count = $"Select Count(*) from client where id_city={dataGridView1.CurrentRow.Cells[0].Value}";
                                    countdel1 = new NpgsqlCommand(count, __conn);
                                    result = MessageBox.Show($"При удалении будет удалено {countdel1.ExecuteScalar()} клиентов.",
                                     "Выберите один из вариантов.", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                     MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); break;
                            }

                            if (result == DialogResult.No)
                            {
                                return;
                            }
                            NpgsqlCommand deleteCommand = new NpgsqlCommand(deleteRowSQL, __conn);
                            deleteCommand.ExecuteNonQuery();
                            LoadNotes();
                        }
                        else
                        {
                            MessageBox.Show("Таблица пустая!");
                        }

                    }
                    if (comboBox1.SelectedItem.ToString() == "Все строки")
                    {
                        switch (Note_choose)
                        {
                            case "типы номеров":
                                Update_ID = "ALTER SEQUENCE roomtype_id_seq RESTART WITH 1" + ";" +
                     "UPDATE roomtype SET id_roomtype = DEFAULT";
                                deleteRowSQL = " DELETE FROM roomtype";
                                result = MessageBox.Show("При удалении будут удалены все номера", "Выберите один из вариантов.", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                break;

                            case "Дополнительные услуги":
                                Update_ID = "ALTER SEQUENCE extraservice_id_seq RESTART WITH 1" + ";" +
                     "UPDATE extraservice SET id_extraservice = DEFAULT";
                                deleteRowSQL = $" DELETE FROM extraservice";
                                result = MessageBox.Show("При удалении будут удалены все номера", "Выберите один из вариантов.", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                break;

                            case "стафферы":
                                Update_ID = "ALTER SEQUENCE staff_id_seq RESTART WITH 1" + ";" +
                     "UPDATE staff SET id_staff = DEFAULT";
                                deleteRowSQL = $" DELETE FROM staff";
                                result = MessageBox.Show("При удалении будут удалены все стафферы", "Выберите один из вариантов.", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                break;

                            case "соц. положения клиентов":
                                Update_ID = "ALTER SEQUENCE socialstatus_id_seq RESTART WITH 1" + ";" +
                            "UPDATE socialstatus SET id_socialstatus = DEFAULT";
                                deleteRowSQL = $" DELETE FROM socialstatus";
                                result = MessageBox.Show("При удалении будут удалены все клиенты", "Выберите один из вариантов.", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                break;

                            case "страны":
                                Update_ID = "ALTER SEQUENCE country_id_seq RESTART WITH 1" + ";" +
                     "UPDATE country SET id_country = DEFAULT";
                                deleteRowSQL = $" DELETE FROM country";
                                result = MessageBox.Show("При удалении будут удалены все города", "Выберите один из вариантов.", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                break;

                            case "квитанции":
                                Update_ID = "ALTER SEQUENCE reservation_id_seq RESTART WITH 1" + ";" +
                     "UPDATE receipt SET id_receipt = DEFAULT";
                                deleteRowSQL = " DELETE FROM reservation";
                                result = MessageBox.Show("При удалении будут удалены все занятия", "Выберите один из вариантов.", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                break;

                            case "клиенты":
                                Update_ID = "ALTER SEQUENCE client_id_seq RESTART WITH 1" + ";" +
                     "UPDATE client SET id_client = DEFAULT";
                                deleteRowSQL = " DELETE FROM client";
                                result = MessageBox.Show("При удалении будут удалены все квитанции", "Выберите один из вариантов.", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                break;

                            case "города":
                                Update_ID = "ALTER SEQUENCE city_id_seq RESTART WITH 1" + ";" +
                     "UPDATE city SET id_city = DEFAULT";
                                deleteRowSQL = " DELETE FROM city";
                                result = MessageBox.Show("При удалении будут удалены все клиенты", "Выберите один из вариантов.", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                break;
                        }
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        /*Обновление последовательности и удаление всей таблицы */

                        NpgsqlCommand deleteCommand = new NpgsqlCommand(deleteRowSQL, __conn);
                        deleteCommand.ExecuteNonQuery();
                        NpgsqlCommand updateCommand = new NpgsqlCommand(Update_ID, __conn);
                        updateCommand.ExecuteNonQuery();
                        LoadNotes();
                        Count_Load();
                    }
                }
                else { MessageBox.Show("Выберите метод удаления записей в БД!"); }
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void странаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Note_choose = "страны";
            LoadNotes();
            Count_Load();
        }

        private void соцПоложениеКлиентаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Note_choose = "соц. положения клиентов";
            LoadNotes();
            Count_Load();
        }

        public void Count_Load()
        {
            if (Note_choose == "типы номеров") sql = ("SELECT COUNT(*) From roomtype ");
            else if (Note_choose == "Дополнительные услуги") sql = ("SELECT COUNT(*) From extraservice");
            else if (Note_choose == "стафферы") sql = ("SELECT COUNT(*) From staff");
            else if (Note_choose == "соц. положения клиентов") sql = ("SELECT COUNT(*) From socialstatus");
            else if (Note_choose == "страны") sql = ("SELECT COUNT(*) from country ");
            else if (Note_choose == "квитанции") sql = ("SELECT COUNT(*) from reservation "); 
            else if (Note_choose == "клиенты") sql = ("SELECT COUNT(*) from client ");
            else if (Note_choose == "города") sql = ("SELECT COUNT(*) from city ");

            NpgsqlCommand count = new NpgsqlCommand(sql, __conn);
            textBox2.Text = count.ExecuteScalar().ToString();
            numeric_Notes.Maximum = (Convert.ToInt32(textBox2.Text) / 15) + 1;

        }
    }
}
