
namespace BD
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиКолвоНомеровСТакимтоТипомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прибыльЗаУказанныйГодВЗависимостиОтТипаНомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типНомераПользующийсяМаксСпросомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подсчётСуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типНомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допУслугаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стафферToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соцПоложениеКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.странаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квитанцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.городToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номераИКлиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отборНомеровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericCountSQL = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Searchlable = new System.Windows.Forms.Label();
            this.Search_SQL = new System.Windows.Forms.TextBox();
            this.Search_Type = new System.Windows.Forms.ComboBox();
            this.CountText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Del_Button = new System.Windows.Forms.Button();
            this.Del_Type = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Room_table = new System.Windows.Forms.DataGridView();
            this.круговаяДиаграммаТиповНомеровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднееКоличествоКлиентовПоТипуНомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоКлиентовСОпределеннымСоцПоложениемВНомерахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_table)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеМенюToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.номераИКлиентыToolStripMenuItem,
            this.отборНомеровToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 29);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // главноеМенюToolStripMenuItem
            // 
            this.главноеМенюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.вывестиКолвоНомеровСТакимтоТипомToolStripMenuItem,
            this.прибыльЗаУказанныйГодВЗависимостиОтТипаНомераToolStripMenuItem,
            this.типНомераПользующийсяМаксСпросомToolStripMenuItem,
            this.подсчётСуToolStripMenuItem,
            this.круговаяДиаграммаТиповНомеровToolStripMenuItem,
            this.среднееКоличествоКлиентовПоТипуНомераToolStripMenuItem,
            this.количествоКлиентовСОпределеннымСоцПоложениемВНомерахToolStripMenuItem});
            this.главноеМенюToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            this.главноеМенюToolStripMenuItem.Size = new System.Drawing.Size(146, 25);
            this.главноеМенюToolStripMenuItem.Text = "Главное меню";
            this.главноеМенюToolStripMenuItem.Click += new System.EventHandler(this.главноеМенюToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(667, 28);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // вывестиКолвоНомеровСТакимтоТипомToolStripMenuItem
            // 
            this.вывестиКолвоНомеровСТакимтоТипомToolStripMenuItem.Name = "вывестиКолвоНомеровСТакимтоТипомToolStripMenuItem";
            this.вывестиКолвоНомеровСТакимтоТипомToolStripMenuItem.Size = new System.Drawing.Size(667, 28);
            this.вывестиКолвоНомеровСТакимтоТипомToolStripMenuItem.Text = "Вывести кол-во номеров с таким-то типом ";
            this.вывестиКолвоНомеровСТакимтоТипомToolStripMenuItem.Click += new System.EventHandler(this.вывестиКолвоНомеровСТакимтоТипомToolStripMenuItem_Click);
            // 
            // прибыльЗаУказанныйГодВЗависимостиОтТипаНомераToolStripMenuItem
            // 
            this.прибыльЗаУказанныйГодВЗависимостиОтТипаНомераToolStripMenuItem.Name = "прибыльЗаУказанныйГодВЗависимостиОтТипаНомераToolStripMenuItem";
            this.прибыльЗаУказанныйГодВЗависимостиОтТипаНомераToolStripMenuItem.Size = new System.Drawing.Size(667, 28);
            this.прибыльЗаУказанныйГодВЗависимостиОтТипаНомераToolStripMenuItem.Text = "Среднее проживание взависимости от типа номера";
            this.прибыльЗаУказанныйГодВЗависимостиОтТипаНомераToolStripMenuItem.Click += new System.EventHandler(this.прибыльЗаУказанныйГодВЗависимостиОтТипаНомераToolStripMenuItem_Click);
            // 
            // типНомераПользующийсяМаксСпросомToolStripMenuItem
            // 
            this.типНомераПользующийсяМаксСпросомToolStripMenuItem.Name = "типНомераПользующийсяМаксСпросомToolStripMenuItem";
            this.типНомераПользующийсяМаксСпросомToolStripMenuItem.Size = new System.Drawing.Size(667, 28);
            this.типНомераПользующийсяМаксСпросомToolStripMenuItem.Text = "Тип номера пользующийся макс. спросом";
            this.типНомераПользующийсяМаксСпросомToolStripMenuItem.Click += new System.EventHandler(this.типНомераПользующийсяМаксСпросомToolStripMenuItem_Click);
            // 
            // подсчётСуToolStripMenuItem
            // 
            this.подсчётСуToolStripMenuItem.Name = "подсчётСуToolStripMenuItem";
            this.подсчётСуToolStripMenuItem.Size = new System.Drawing.Size(667, 28);
            this.подсчётСуToolStripMenuItem.Text = "Подсчёт прибыли";
            this.подсчётСуToolStripMenuItem.Click += new System.EventHandler(this.подсчётСуToolStripMenuItem_Click);
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
            this.городToolStripMenuItem});
            this.справочникиToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(140, 25);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // типНомераToolStripMenuItem
            // 
            this.типНомераToolStripMenuItem.Name = "типНомераToolStripMenuItem";
            this.типНомераToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.типНомераToolStripMenuItem.Text = "Тип номера";
            this.типНомераToolStripMenuItem.Click += new System.EventHandler(this.типНомераToolStripMenuItem_Click);
            // 
            // допУслугаToolStripMenuItem
            // 
            this.допУслугаToolStripMenuItem.Name = "допУслугаToolStripMenuItem";
            this.допУслугаToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.допУслугаToolStripMenuItem.Text = "Доп. Услуга";
            this.допУслугаToolStripMenuItem.Click += new System.EventHandler(this.допУслугаToolStripMenuItem_Click);
            // 
            // стафферToolStripMenuItem
            // 
            this.стафферToolStripMenuItem.Name = "стафферToolStripMenuItem";
            this.стафферToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.стафферToolStripMenuItem.Text = "Стаффер";
            this.стафферToolStripMenuItem.Click += new System.EventHandler(this.стафферToolStripMenuItem_Click);
            // 
            // соцПоложениеКлиентаToolStripMenuItem
            // 
            this.соцПоложениеКлиентаToolStripMenuItem.Name = "соцПоложениеКлиентаToolStripMenuItem";
            this.соцПоложениеКлиентаToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.соцПоложениеКлиентаToolStripMenuItem.Text = "Соц.Положение клиента";
            this.соцПоложениеКлиентаToolStripMenuItem.Click += new System.EventHandler(this.соцПоложениеКлиентаToolStripMenuItem_Click);
            // 
            // странаToolStripMenuItem
            // 
            this.странаToolStripMenuItem.Name = "странаToolStripMenuItem";
            this.странаToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.странаToolStripMenuItem.Text = "Страна ";
            this.странаToolStripMenuItem.Click += new System.EventHandler(this.странаToolStripMenuItem_Click);
            // 
            // квитанцияToolStripMenuItem
            // 
            this.квитанцияToolStripMenuItem.Name = "квитанцияToolStripMenuItem";
            this.квитанцияToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.квитанцияToolStripMenuItem.Text = "Квитанция";
            this.квитанцияToolStripMenuItem.Click += new System.EventHandler(this.квитанцияToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // городToolStripMenuItem
            // 
            this.городToolStripMenuItem.Name = "городToolStripMenuItem";
            this.городToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.городToolStripMenuItem.Text = "Город";
            this.городToolStripMenuItem.Click += new System.EventHandler(this.городToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(137, 25);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // номераИКлиентыToolStripMenuItem
            // 
            this.номераИКлиентыToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номераИКлиентыToolStripMenuItem.Name = "номераИКлиентыToolStripMenuItem";
            this.номераИКлиентыToolStripMenuItem.Size = new System.Drawing.Size(184, 25);
            this.номераИКлиентыToolStripMenuItem.Text = "Номера и клиенты";
            this.номераИКлиентыToolStripMenuItem.Click += new System.EventHandler(this.номераИКлиентыToolStripMenuItem_Click);
            // 
            // отборНомеровToolStripMenuItem
            // 
            this.отборНомеровToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отборНомеровToolStripMenuItem.Name = "отборНомеровToolStripMenuItem";
            this.отборНомеровToolStripMenuItem.Size = new System.Drawing.Size(158, 25);
            this.отборНомеровToolStripMenuItem.Text = "Отбор номеров";
            this.отборНомеровToolStripMenuItem.Click += new System.EventHandler(this.отборНомеровToolStripMenuItem_Click);
            // 
            // numericCountSQL
            // 
            this.numericCountSQL.Location = new System.Drawing.Point(665, 87);
            this.numericCountSQL.MinimumSize = new System.Drawing.Size(1, 0);
            this.numericCountSQL.Name = "numericCountSQL";
            this.numericCountSQL.Size = new System.Drawing.Size(120, 20);
            this.numericCountSQL.TabIndex = 18;
            this.numericCountSQL.ValueChanged += new System.EventHandler(this.numericCountSQL_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(570, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Страница";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Searchlable
            // 
            this.Searchlable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Searchlable.AutoSize = true;
            this.Searchlable.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Searchlable.Location = new System.Drawing.Point(11, 89);
            this.Searchlable.Name = "Searchlable";
            this.Searchlable.Size = new System.Drawing.Size(66, 21);
            this.Searchlable.TabIndex = 16;
            this.Searchlable.Text = "Поиск ";
            this.Searchlable.Click += new System.EventHandler(this.Searchlable_Click);
            // 
            // Search_SQL
            // 
            this.Search_SQL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Search_SQL.Location = new System.Drawing.Point(83, 89);
            this.Search_SQL.Name = "Search_SQL";
            this.Search_SQL.Size = new System.Drawing.Size(190, 20);
            this.Search_SQL.TabIndex = 15;
            this.Search_SQL.TextChanged += new System.EventHandler(this.Search_SQL_TextChanged);
            this.Search_SQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Search_Type
            // 
            this.Search_Type.FormattingEnabled = true;
            this.Search_Type.Items.AddRange(new object[] {
            "ID",
            "Тип_комнаты",
            "Колво_кроватей",
            "Этаж",
            "Размер_оплаты"});
            this.Search_Type.Location = new System.Drawing.Point(275, 88);
            this.Search_Type.MaximumSize = new System.Drawing.Size(127, 0);
            this.Search_Type.Name = "Search_Type";
            this.Search_Type.Size = new System.Drawing.Size(127, 21);
            this.Search_Type.TabIndex = 19;
            this.Search_Type.SelectedIndexChanged += new System.EventHandler(this.Search_Type_SelectedIndexChanged);
            // 
            // CountText
            // 
            this.CountText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CountText.Location = new System.Drawing.Point(274, 420);
            this.CountText.Name = "CountText";
            this.CountText.ReadOnly = true;
            this.CountText.Size = new System.Drawing.Size(127, 20);
            this.CountText.TabIndex = 24;
            this.CountText.TextChanged += new System.EventHandler(this.CountText_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(237, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Общее количество номеров";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Del_Button
            // 
            this.Del_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Del_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Del_Button.Location = new System.Drawing.Point(652, 402);
            this.Del_Button.Name = "Del_Button";
            this.Del_Button.Size = new System.Drawing.Size(139, 29);
            this.Del_Button.TabIndex = 22;
            this.Del_Button.Text = "Удалить";
            this.Del_Button.UseVisualStyleBackColor = true;
            this.Del_Button.Click += new System.EventHandler(this.Del_Button_Click);
            // 
            // Del_Type
            // 
            this.Del_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Del_Type.FormattingEnabled = true;
            this.Del_Type.Items.AddRange(new object[] {
            "Одну строку",
            "Все поля"});
            this.Del_Type.Location = new System.Drawing.Point(494, 408);
            this.Del_Type.Name = "Del_Type";
            this.Del_Type.Size = new System.Drawing.Size(152, 21);
            this.Del_Type.TabIndex = 21;
            this.Del_Type.SelectedIndexChanged += new System.EventHandler(this.Del_Type_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.AddButton.Location = new System.Drawing.Point(11, 411);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(158, 29);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Добавить автошколу";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Room_table
            // 
            this.Room_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_table.Location = new System.Drawing.Point(11, 132);
            this.Room_table.Name = "Room_table";
            this.Room_table.RowTemplate.Height = 25;
            this.Room_table.Size = new System.Drawing.Size(776, 247);
            this.Room_table.TabIndex = 31;
            this.Room_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // круговаяДиаграммаТиповНомеровToolStripMenuItem
            // 
            this.круговаяДиаграммаТиповНомеровToolStripMenuItem.Name = "круговаяДиаграммаТиповНомеровToolStripMenuItem";
            this.круговаяДиаграммаТиповНомеровToolStripMenuItem.Size = new System.Drawing.Size(667, 28);
            this.круговаяДиаграммаТиповНомеровToolStripMenuItem.Text = "Круговая диаграмма типов номеров";
            this.круговаяДиаграммаТиповНомеровToolStripMenuItem.Click += new System.EventHandler(this.круговаяДиаграммаТиповНомеровToolStripMenuItem_Click);
            // 
            // среднееКоличествоКлиентовПоТипуНомераToolStripMenuItem
            // 
            this.среднееКоличествоКлиентовПоТипуНомераToolStripMenuItem.Name = "среднееКоличествоКлиентовПоТипуНомераToolStripMenuItem";
            this.среднееКоличествоКлиентовПоТипуНомераToolStripMenuItem.Size = new System.Drawing.Size(667, 28);
            this.среднееКоличествоКлиентовПоТипуНомераToolStripMenuItem.Text = "Среднее количество клиентов по типу номера";
            this.среднееКоличествоКлиентовПоТипуНомераToolStripMenuItem.Click += new System.EventHandler(this.среднееКоличествоКлиентовПоТипуНомераToolStripMenuItem_Click);
            // 
            // количествоКлиентовСОпределеннымСоцПоложениемВНомерахToolStripMenuItem
            // 
            this.количествоКлиентовСОпределеннымСоцПоложениемВНомерахToolStripMenuItem.Name = "количествоКлиентовСОпределеннымСоцПоложениемВНомерахToolStripMenuItem";
            this.количествоКлиентовСОпределеннымСоцПоложениемВНомерахToolStripMenuItem.Size = new System.Drawing.Size(667, 28);
            this.количествоКлиентовСОпределеннымСоцПоложениемВНомерахToolStripMenuItem.Text = "Количество клиентов с определенным соц. положением в номерах";
            this.количествоКлиентовСОпределеннымСоцПоложениемВНомерахToolStripMenuItem.Click += new System.EventHandler(this.количествоКлиентовСОпределеннымСоцПоложениемВНомерахToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.Room_table);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Del_Button);
            this.Controls.Add(this.Del_Type);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Search_Type);
            this.Controls.Add(this.numericCountSQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Searchlable);
            this.Controls.Add(this.Search_SQL);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericCountSQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Searchlable;
        private System.Windows.Forms.TextBox Search_SQL;
        private System.Windows.Forms.ComboBox Search_Type;
        private System.Windows.Forms.TextBox CountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Del_Button;
        private System.Windows.Forms.ComboBox Del_Type;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типНомераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допУслугаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стафферToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соцПоложениеКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem странаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квитанцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem городToolStripMenuItem;
        private System.Windows.Forms.DataGridView Room_table;
        private System.Windows.Forms.ToolStripMenuItem номераИКлиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отборНомеровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиКолвоНомеровСТакимтоТипомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прибыльЗаУказанныйГодВЗависимостиОтТипаНомераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типНомераПользующийсяМаксСпросомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подсчётСуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem круговаяДиаграммаТиповНомеровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднееКоличествоКлиентовПоТипуНомераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоКлиентовСОпределеннымСоцПоложениемВНомерахToolStripMenuItem;
    }
}