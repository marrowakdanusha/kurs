
namespace BD
{
    partial class Notes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_Notes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типНомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допУслугаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стафферToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соцПоложениеКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.странаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квитанцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.городаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаНомеровПоТипуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаКлиентовПоСоцПоложениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаКлиентовПоГородамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общаяЦенаВсехДопУслугНомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Notes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Страница";
            // 
            // numeric_Notes
            // 
            this.numeric_Notes.Location = new System.Drawing.Point(101, 50);
            this.numeric_Notes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Notes.Name = "numeric_Notes";
            this.numeric_Notes.Size = new System.Drawing.Size(120, 20);
            this.numeric_Notes.TabIndex = 19;
            this.numeric_Notes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Notes.ValueChanged += new System.EventHandler(this.numeric_Notes_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Количество записей";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(265, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Одну строку",
            "Все строки"});
            this.comboBox1.Location = new System.Drawing.Point(395, 344);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(532, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(36, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 254);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // главноеМенюToolStripMenuItem
            // 
            this.главноеМенюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.главноеМенюToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            this.главноеМенюToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.главноеМенюToolStripMenuItem.Text = "Главное меню";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типНомераToolStripMenuItem,
            this.допУслугаToolStripMenuItem,
            this.стафферToolStripMenuItem,
            this.соцПоложениеКлиентаToolStripMenuItem,
            this.странаToolStripMenuItem,
            this.квитанцияToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.городаToolStripMenuItem,
            this.запросыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(131, 25);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // типНомераToolStripMenuItem
            // 
            this.типНомераToolStripMenuItem.Name = "типНомераToolStripMenuItem";
            this.типНомераToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.типНомераToolStripMenuItem.Text = "Тип номера";
            this.типНомераToolStripMenuItem.Click += new System.EventHandler(this.типНомераToolStripMenuItem_Click_1);
            // 
            // допУслугаToolStripMenuItem
            // 
            this.допУслугаToolStripMenuItem.Name = "допУслугаToolStripMenuItem";
            this.допУслугаToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.допУслугаToolStripMenuItem.Text = "Доп. Услуга";
            this.допУслугаToolStripMenuItem.Click += new System.EventHandler(this.допУслугаToolStripMenuItem_Click_1);
            // 
            // стафферToolStripMenuItem
            // 
            this.стафферToolStripMenuItem.Name = "стафферToolStripMenuItem";
            this.стафферToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.стафферToolStripMenuItem.Text = "Стаффер";
            this.стафферToolStripMenuItem.Click += new System.EventHandler(this.стафферToolStripMenuItem_Click_1);
            // 
            // соцПоложениеКлиентаToolStripMenuItem
            // 
            this.соцПоложениеКлиентаToolStripMenuItem.Name = "соцПоложениеКлиентаToolStripMenuItem";
            this.соцПоложениеКлиентаToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.соцПоложениеКлиентаToolStripMenuItem.Text = "Соц.Положение клиента";
            this.соцПоложениеКлиентаToolStripMenuItem.Click += new System.EventHandler(this.соцПоложениеКлиентаToolStripMenuItem_Click_1);
            // 
            // странаToolStripMenuItem
            // 
            this.странаToolStripMenuItem.Name = "странаToolStripMenuItem";
            this.странаToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.странаToolStripMenuItem.Text = "Страна ";
            this.странаToolStripMenuItem.Click += new System.EventHandler(this.странаToolStripMenuItem_Click_1);
            // 
            // квитанцияToolStripMenuItem
            // 
            this.квитанцияToolStripMenuItem.Name = "квитанцияToolStripMenuItem";
            this.квитанцияToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.квитанцияToolStripMenuItem.Text = "Квитанция";
            this.квитанцияToolStripMenuItem.Click += new System.EventHandler(this.квитанцияToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // городаToolStripMenuItem
            // 
            this.городаToolStripMenuItem.Name = "городаToolStripMenuItem";
            this.городаToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.городаToolStripMenuItem.Text = "Города";
            this.городаToolStripMenuItem.Click += new System.EventHandler(this.городаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(74, 25);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip2.BackgroundImage")));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеМенюToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(730, 29);
            this.menuStrip2.TabIndex = 21;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "От";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "До";
            this.label4.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(575, 43);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker2.TabIndex = 24;
            this.dateTimePicker2.Visible = false;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(242, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Сортировать по дате";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаНомеровПоТипуToolStripMenuItem,
            this.сортировкаКлиентовПоСоцПоложениюToolStripMenuItem,
            this.сортировкаКлиентовПоГородамToolStripMenuItem,
            this.общаяЦенаВсехДопУслугНомераToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // сортировкаНомеровПоТипуToolStripMenuItem
            // 
            this.сортировкаНомеровПоТипуToolStripMenuItem.Name = "сортировкаНомеровПоТипуToolStripMenuItem";
            this.сортировкаНомеровПоТипуToolStripMenuItem.Size = new System.Drawing.Size(418, 26);
            this.сортировкаНомеровПоТипуToolStripMenuItem.Text = "Сортировка номеров по типу";
            this.сортировкаНомеровПоТипуToolStripMenuItem.Click += new System.EventHandler(this.сортировкаНомеровПоТипуToolStripMenuItem_Click);
            // 
            // сортировкаКлиентовПоСоцПоложениюToolStripMenuItem
            // 
            this.сортировкаКлиентовПоСоцПоложениюToolStripMenuItem.Name = "сортировкаКлиентовПоСоцПоложениюToolStripMenuItem";
            this.сортировкаКлиентовПоСоцПоложениюToolStripMenuItem.Size = new System.Drawing.Size(418, 26);
            this.сортировкаКлиентовПоСоцПоложениюToolStripMenuItem.Text = "Сортировка клиентов по соц. положению";
            this.сортировкаКлиентовПоСоцПоложениюToolStripMenuItem.Click += new System.EventHandler(this.сортировкаКлиентовПоСоцПоложениюToolStripMenuItem_Click);
            // 
            // сортировкаКлиентовПоГородамToolStripMenuItem
            // 
            this.сортировкаКлиентовПоГородамToolStripMenuItem.Name = "сортировкаКлиентовПоГородамToolStripMenuItem";
            this.сортировкаКлиентовПоГородамToolStripMenuItem.Size = new System.Drawing.Size(418, 26);
            this.сортировкаКлиентовПоГородамToolStripMenuItem.Text = "Сортировка клиентов по городам";
            this.сортировкаКлиентовПоГородамToolStripMenuItem.Click += new System.EventHandler(this.сортировкаКлиентовПоГородамToolStripMenuItem_Click);
            // 
            // общаяЦенаВсехДопУслугНомераToolStripMenuItem
            // 
            this.общаяЦенаВсехДопУслугНомераToolStripMenuItem.Name = "общаяЦенаВсехДопУслугНомераToolStripMenuItem";
            this.общаяЦенаВсехДопУслугНомераToolStripMenuItem.Size = new System.Drawing.Size(418, 26);
            this.общаяЦенаВсехДопУслугНомераToolStripMenuItem.Text = "Общая цена всех доп. услуг номера";
            this.общаяЦенаВсехДопУслугНомераToolStripMenuItem.Click += new System.EventHandler(this.общаяЦенаВсехДопУслугНомераToolStripMenuItem_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(730, 398);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeric_Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Notes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_Notes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типНомераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допУслугаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стафферToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соцПоложениеКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem странаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квитанцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem городаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаНомеровПоТипуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаКлиентовПоСоцПоложениюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаКлиентовПоГородамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общаяЦенаВсехДопУслугНомераToolStripMenuItem;
    }
}