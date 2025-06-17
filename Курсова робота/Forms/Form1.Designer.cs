using System.Windows.Forms;

namespace Курсова_робота
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Add = new Button();
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            txtDistance = new TextBox();
            txtCoordinates = new TextBox();
            comboBox1 = new ComboBox();
            txtMagnitude = new TextBox();
            addStars = new Button();
            constellationInf = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            label21 = new Label();
            label20 = new Label();
            btnUnload = new Button();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            btnVisibleStars = new Button();
            dtpObservationTime = new DateTimePicker();
            txtLongitude = new TextBox();
            txtLatitude = new TextBox();
            label14 = new Label();
            txtRightAscension = new TextBox();
            sortCriteria = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboSearchBy = new ComboBox();
            txtSearchAll = new TextBox();
            Search = new Button();
            btnSave = new Button();
            button2 = new Button();
            btnChange = new Button();
            label4 = new Label();
            label3 = new Label();
            cmbStars = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pbPhoto = new PictureBox();
            btnAddPhoto = new Button();
            txtRadius = new TextBox();
            txtMass = new TextBox();
            comboColor = new ComboBox();
            comboBoxStard = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            Zodiac = new DataGridViewTextBoxColumn();
            NotableObjects = new DataGridViewTextBoxColumn();
            StarNamesString = new DataGridViewTextBoxColumn();
            StarCount = new DataGridViewTextBoxColumn();
            AllStars = new DataGridViewTextBoxColumn();
            Names = new DataGridViewTextBoxColumn();
            Change = new DataGridViewButtonColumn();
            colImg = new DataGridViewImageColumn();
            colImagePath = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCol = new DataGridViewTextBoxColumn();
            colConstellation = new DataGridViewTextBoxColumn();
            colMagnitude = new DataGridViewTextBoxColumn();
            colMass = new DataGridViewTextBoxColumn();
            colRad = new DataGridViewTextBoxColumn();
            coldistance = new DataGridViewTextBoxColumn();
            colCoordinates = new DataGridViewTextBoxColumn();
            ColRightAscension = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            SuspendLayout();
            // 
            // Add
            // 
            Add.BackColor = SystemColors.GradientInactiveCaption;
            Add.Font = new Font("Segoe UI", 12F);
            Add.Location = new Point(20, 205);
            Add.Name = "Add";
            Add.Size = new Size(227, 49);
            Add.TabIndex = 0;
            Add.Text = "Додати зірку";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colImg, colImagePath, colName, colCol, colConstellation, colMagnitude, colMass, colRad, coldistance, colCoordinates, ColRightAscension });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(603, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SlateBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(1619, 797);
            dataGridView1.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.InactiveCaptionText;
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(23, 322);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 42);
            txtName.TabIndex = 7;
            // 
            // txtDistance
            // 
            txtDistance.BackColor = SystemColors.InactiveCaptionText;
            txtDistance.Font = new Font("Segoe UI", 11F);
            txtDistance.ForeColor = SystemColors.InactiveBorder;
            txtDistance.Location = new Point(23, 528);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(224, 42);
            txtDistance.TabIndex = 10;
            // 
            // txtCoordinates
            // 
            txtCoordinates.BackColor = SystemColors.InactiveCaptionText;
            txtCoordinates.Font = new Font("Segoe UI", 11F);
            txtCoordinates.ForeColor = SystemColors.InactiveBorder;
            txtCoordinates.Location = new Point(23, 425);
            txtCoordinates.Name = "txtCoordinates";
            txtCoordinates.Size = new Size(224, 42);
            txtCoordinates.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ControlLightLight;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.ForeColor = SystemColors.InactiveCaptionText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Андромеда", "Близнята", "Велика Ведмедиця", "Великий Пес", "Візничий", "Вітрила", "Вовк", "Водолій", "Волопас", "Волосся Вероніки", "Ворон", "Геркулес", "Гідра", "Годинник", "Голуб", "Гончі Пси", "Дельфін", "Діва", "Дракон", "Ерідан", "Єдиноріг", "Жертовник", "Живописець", "Жираф", "Журавель", "Заєць", "Змієносець", "Змія", "Золота Риба", "Індіанець", "Кассіопея", "Кит", "Кіль", "Козеріг", "Компас", "Корма", "Косинець", "Лебідь", "Лев", "Летюча Риба", "Лисичка", "Ліра", "Мала Ведмедиця", "Малий Кінь", "Малий Лев", "Малий Пес", "Мікроскоп", "Муха", "Насос", "Овен", "Октант", "Орел", "Оріон", "Павич", "Пегас", "Персей", "Південна Гідра", "Південна Корона", "Південна Риба", "Південний Трикутник", "Південний Хрест", "Північна Корона", "Піч", "Райський Птах", "Рак", "Риби", "Рись", "Різець", "Секстант", "Сітка", "Скорпіон", "Скульптор", "Столова Гора", "Стріла", "Стрілець", "Телескоп", "Телець", "Терези", "Трикутник", "Тукан", "Фенікс", "Хамелеон", "Центавр", "Цефей", "Циркуль", "Чаша", "Щит", "Ящірка" });
            comboBox1.Location = new Point(299, 632);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 39);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtMagnitude
            // 
            txtMagnitude.BackColor = SystemColors.InactiveCaptionText;
            txtMagnitude.Font = new Font("Segoe UI", 11F);
            txtMagnitude.ForeColor = SystemColors.InactiveBorder;
            txtMagnitude.Location = new Point(299, 322);
            txtMagnitude.Name = "txtMagnitude";
            txtMagnitude.Size = new Size(224, 42);
            txtMagnitude.TabIndex = 8;
            // 
            // addStars
            // 
            addStars.BackColor = Color.DarkSlateBlue;
            addStars.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addStars.ForeColor = SystemColors.Control;
            addStars.Location = new Point(946, 32);
            addStars.Name = "addStars";
            addStars.Size = new Size(333, 66);
            addStars.TabIndex = 13;
            addStars.Text = "Зорі";
            addStars.UseVisualStyleBackColor = false;
            addStars.Click += addStars_Click;
            // 
            // constellationInf
            // 
            constellationInf.BackColor = Color.DarkSlateBlue;
            constellationInf.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            constellationInf.ForeColor = SystemColors.Control;
            constellationInf.Location = new Point(1336, 32);
            constellationInf.Name = "constellationInf";
            constellationInf.Size = new Size(333, 66);
            constellationInf.TabIndex = 14;
            constellationInf.Text = "Сузір'я";
            constellationInf.UseVisualStyleBackColor = false;
            constellationInf.Click += constellationInf_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(btnUnload);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(btnVisibleStars);
            panel1.Controls.Add(dtpObservationTime);
            panel1.Controls.Add(txtLongitude);
            panel1.Controls.Add(txtLatitude);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtRightAscension);
            panel1.Controls.Add(sortCriteria);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboSearchBy);
            panel1.Controls.Add(txtSearchAll);
            panel1.Controls.Add(Search);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnChange);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbStars);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbPhoto);
            panel1.Controls.Add(btnAddPhoto);
            panel1.Controls.Add(txtRadius);
            panel1.Controls.Add(txtMass);
            panel1.Controls.Add(comboColor);
            panel1.Controls.Add(Add);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txtCoordinates);
            panel1.Controls.Add(txtDistance);
            panel1.Controls.Add(txtMagnitude);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(comboBoxStard);
            panel1.Font = new Font("Segoe UI", 11.5F);
            panel1.Location = new Point(-4, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(2525, 978);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dataGridView2);
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(2525, 975);
            panel2.TabIndex = 36;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.5F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Change, Names, AllStars, StarCount, StarNamesString, NotableObjects, Zodiac });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Black;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.5F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle6.SelectionBackColor = Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.GridColor = SystemColors.ControlLightLight;
            dataGridView2.Location = new Point(427, 59);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11.5F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.Size = new Size(1595, 856);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11F);
            label21.ForeColor = SystemColors.ControlDarkDark;
            label21.Location = new Point(1748, 57);
            label21.Name = "label21";
            label21.Size = new Size(442, 36);
            label21.TabIndex = 59;
            label21.Text = "                                                             ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11F);
            label20.ForeColor = SystemColors.ControlDarkDark;
            label20.Location = new Point(1358, 62);
            label20.Name = "label20";
            label20.Size = new Size(211, 36);
            label20.TabIndex = 58;
            label20.Text = "                            ";
            // 
            // btnUnload
            // 
            btnUnload.BackColor = SystemColors.GradientInactiveCaption;
            btnUnload.Font = new Font("Segoe UI", 12F);
            btnUnload.Location = new Point(20, 135);
            btnUnload.Name = "btnUnload";
            btnUnload.Size = new Size(227, 49);
            btnUnload.TabIndex = 57;
            btnUnload.Text = "Вивантажити";
            btnUnload.UseVisualStyleBackColor = false;
            btnUnload.Click += btnUnload_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F);
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(2339, 499);
            label19.Name = "label19";
            label19.Size = new Size(88, 36);
            label19.TabIndex = 56;
            label19.Text = "W → E";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(2291, 451);
            label18.Name = "label18";
            label18.Size = new Size(183, 36);
            label18.TabIndex = 55;
            label18.Text = "-180° → +180°";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F);
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(2339, 311);
            label17.Name = "label17";
            label17.Size = new Size(84, 36);
            label17.TabIndex = 54;
            label17.Text = "S → N";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F);
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(2308, 264);
            label16.Name = "label16";
            label16.Size = new Size(155, 36);
            label16.TabIndex = 53;
            label16.Text = "-90° → +90°";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F);
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(1891, 17);
            label15.Name = "label15";
            label15.Size = new Size(155, 36);
            label15.TabIndex = 52;
            label15.Text = "Сортування";
            // 
            // btnVisibleStars
            // 
            btnVisibleStars.BackColor = SystemColors.GradientInactiveCaption;
            btnVisibleStars.Font = new Font("Segoe UI", 12F);
            btnVisibleStars.Location = new Point(2262, 61);
            btnVisibleStars.Name = "btnVisibleStars";
            btnVisibleStars.Size = new Size(243, 104);
            btnVisibleStars.TabIndex = 51;
            btnVisibleStars.Text = "Показати видимі зірки";
            btnVisibleStars.UseVisualStyleBackColor = false;
            btnVisibleStars.Click += btnVisibleStars_Click;
            // 
            // dtpObservationTime
            // 
            dtpObservationTime.CustomFormat = "MM/dd/yyyy HH:mm";
            dtpObservationTime.Format = DateTimePickerFormat.Custom;
            dtpObservationTime.Location = new Point(2238, 204);
            dtpObservationTime.Name = "dtpObservationTime";
            dtpObservationTime.Size = new Size(276, 43);
            dtpObservationTime.TabIndex = 50;
            // 
            // txtLongitude
            // 
            txtLongitude.BackColor = SystemColors.InactiveCaptionText;
            txtLongitude.ForeColor = SystemColors.InactiveBorder;
            txtLongitude.Location = new Point(2299, 551);
            txtLongitude.Name = "txtLongitude";
            txtLongitude.PlaceholderText = "Довгота";
            txtLongitude.Size = new Size(175, 43);
            txtLongitude.TabIndex = 49;
            // 
            // txtLatitude
            // 
            txtLatitude.BackColor = SystemColors.InactiveCaptionText;
            txtLatitude.ForeColor = SystemColors.InactiveBorder;
            txtLatitude.Location = new Point(2299, 372);
            txtLatitude.Name = "txtLatitude";
            txtLatitude.PlaceholderText = "Широта";
            txtLatitude.Size = new Size(175, 43);
            txtLatitude.TabIndex = 48;
            txtLatitude.Tag = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(13, 588);
            label14.Name = "label14";
            label14.Size = new Size(234, 36);
            label14.TabIndex = 47;
            label14.Text = "Пряме піднесення";
            // 
            // txtRightAscension
            // 
            txtRightAscension.BackColor = SystemColors.InactiveCaptionText;
            txtRightAscension.Font = new Font("Segoe UI", 11F);
            txtRightAscension.ForeColor = SystemColors.InactiveBorder;
            txtRightAscension.Location = new Point(20, 627);
            txtRightAscension.Name = "txtRightAscension";
            txtRightAscension.Size = new Size(224, 42);
            txtRightAscension.TabIndex = 46;
            // 
            // sortCriteria
            // 
            sortCriteria.DropDownStyle = ComboBoxStyle.DropDownList;
            sortCriteria.Font = new Font("Segoe UI", 10F);
            sortCriteria.FormattingEnabled = true;
            sortCriteria.Items.AddRange(new object[] { "Зірки за алфавітом", "Зірки за кольорами", "Зірки за сузір'ям", "Найяскравіші зірки", "Зірки з найбільшою масою", "Найбільші зірки", "Найближчі зірки" });
            sortCriteria.Location = new Point(1746, 56);
            sortCriteria.Name = "sortCriteria";
            sortCriteria.Size = new Size(476, 39);
            sortCriteria.TabIndex = 45;
            sortCriteria.SelectedIndexChanged += sortCriteria_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(359, 593);
            label13.Name = "label13";
            label13.Size = new Size(96, 36);
            label13.TabIndex = 44;
            label13.Text = "Сузір'я";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(88, 692);
            label12.Name = "label12";
            label12.Size = new Size(80, 36);
            label12.TabIndex = 43;
            label12.Text = "Колір";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(365, 489);
            label11.Name = "label11";
            label11.Size = new Size(88, 36);
            label11.TabIndex = 42;
            label11.Text = "Радіус";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(73, 489);
            label10.Name = "label10";
            label10.Size = new Size(114, 36);
            label10.TabIndex = 41;
            label10.Text = "Відстань";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(367, 386);
            label9.Name = "label9";
            label9.Size = new Size(76, 36);
            label9.TabIndex = 40;
            label9.Text = "Маса";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(73, 386);
            label8.Name = "label8";
            label8.Size = new Size(129, 36);
            label8.TabIndex = 39;
            label8.Text = "Схилення";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(301, 283);
            label7.Name = "label7";
            label7.Size = new Size(222, 36);
            label7.TabIndex = 38;
            label7.Text = "Зоряна величина";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(88, 283);
            label6.Name = "label6";
            label6.Size = new Size(85, 36);
            label6.TabIndex = 37;
            label6.Text = "Назва";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(1374, 20);
            label5.Name = "label5";
            label5.Size = new Size(218, 36);
            label5.TabIndex = 35;
            label5.Text = "Критерій пошуку";
            // 
            // comboSearchBy
            // 
            comboSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSearchBy.Font = new Font("Segoe UI", 10F);
            comboSearchBy.FormattingEnabled = true;
            comboSearchBy.Items.AddRange(new object[] { "Назва", "Колір", "Сузір'я", "Зоряна величина", "Схилення", "Відстань", "Маса", "Радіус", "Пряме піднесення", "Координати", "Всі" });
            comboSearchBy.Location = new Point(1356, 61);
            comboSearchBy.Name = "comboSearchBy";
            comboSearchBy.Size = new Size(249, 39);
            comboSearchBy.TabIndex = 34;
            comboSearchBy.SelectedIndexChanged += comboSearchBy_SelectedIndexChanged;
            // 
            // txtSearchAll
            // 
            txtSearchAll.BackColor = SystemColors.InactiveCaptionText;
            txtSearchAll.Font = new Font("Segoe UI", 11F);
            txtSearchAll.ForeColor = SystemColors.InactiveBorder;
            txtSearchAll.Location = new Point(603, 61);
            txtSearchAll.Name = "txtSearchAll";
            txtSearchAll.PlaceholderText = "Пошук";
            txtSearchAll.Size = new Size(726, 42);
            txtSearchAll.TabIndex = 33;
            // 
            // Search
            // 
            Search.BackColor = SystemColors.GradientInactiveCaption;
            Search.Font = new Font("Segoe UI", 9F);
            Search.Location = new Point(1624, 61);
            Search.Name = "Search";
            Search.Size = new Size(49, 39);
            Search.TabIndex = 32;
            Search.Text = "ок";
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientInactiveCaption;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(20, 67);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(227, 49);
            btnSave.TabIndex = 0;
            btnSave.Text = "Завантажити";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(505, 97);
            button2.Name = "button2";
            button2.Size = new Size(49, 46);
            button2.TabIndex = 30;
            button2.Text = "ок";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = SystemColors.GradientInactiveCaption;
            btnChange.Font = new Font("Segoe UI", 9F);
            btnChange.Location = new Point(505, 170);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(49, 46);
            btnChange.TabIndex = 29;
            btnChange.Text = "ок";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(296, 100);
            label4.Name = "label4";
            label4.Size = new Size(152, 38);
            label4.TabIndex = 27;
            label4.Text = "Видалити  ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(296, 173);
            label3.Name = "label3";
            label3.Size = new Size(150, 38);
            label3.TabIndex = 26;
            label3.Text = "Змінити    ";
            // 
            // cmbStars
            // 
            cmbStars.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStars.Font = new Font("Segoe UI", 12F);
            cmbStars.FormattingEnabled = true;
            cmbStars.Location = new Point(295, 170);
            cmbStars.Name = "cmbStars";
            cmbStars.Size = new Size(183, 46);
            cmbStars.TabIndex = 0;
            cmbStars.SelectedIndexChanged += cmbStars_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(301, 633);
            label2.Name = "label2";
            label2.Size = new Size(190, 36);
            label2.TabIndex = 23;
            label2.Text = "                         ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(22, 733);
            label1.Name = "label1";
            label1.Size = new Size(190, 36);
            label1.TabIndex = 22;
            label1.Text = "                         ";
            // 
            // pbPhoto
            // 
            pbPhoto.BackColor = SystemColors.ActiveCaptionText;
            pbPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbPhoto.Location = new Point(299, 702);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(224, 200);
            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhoto.TabIndex = 21;
            pbPhoto.TabStop = false;
            // 
            // btnAddPhoto
            // 
            btnAddPhoto.BackColor = SystemColors.GradientInactiveCaption;
            btnAddPhoto.Font = new Font("Segoe UI", 10F);
            btnAddPhoto.Location = new Point(31, 812);
            btnAddPhoto.Name = "btnAddPhoto";
            btnAddPhoto.Size = new Size(182, 40);
            btnAddPhoto.TabIndex = 20;
            btnAddPhoto.Text = "Вибрати файл";
            btnAddPhoto.UseVisualStyleBackColor = false;
            btnAddPhoto.Click += btnAddPhoto_Click;
            // 
            // txtRadius
            // 
            txtRadius.BackColor = SystemColors.InactiveCaptionText;
            txtRadius.Font = new Font("Segoe UI", 11F);
            txtRadius.ForeColor = SystemColors.InactiveBorder;
            txtRadius.Location = new Point(299, 528);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(224, 42);
            txtRadius.TabIndex = 19;
            // 
            // txtMass
            // 
            txtMass.BackColor = SystemColors.InactiveCaptionText;
            txtMass.Font = new Font("Segoe UI", 11F);
            txtMass.ForeColor = SystemColors.InactiveBorder;
            txtMass.Location = new Point(299, 425);
            txtMass.Name = "txtMass";
            txtMass.Size = new Size(224, 42);
            txtMass.TabIndex = 18;
            // 
            // comboColor
            // 
            comboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboColor.Font = new Font("Segoe UI", 10F);
            comboColor.FormattingEnabled = true;
            comboColor.Items.AddRange(new object[] { "Голубий", "Біло-голубий", "Білий", "Жовто-білий", "Жовтий", "Оранжевий", "Червоний" });
            comboColor.Location = new Point(20, 731);
            comboColor.Name = "comboColor";
            comboColor.Size = new Size(224, 39);
            comboColor.TabIndex = 17;
            comboColor.SelectedIndexChanged += comboColor_SelectedIndexChanged;
            // 
            // comboBoxStard
            // 
            comboBoxStard.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxStard.FormattingEnabled = true;
            comboBoxStard.Location = new Point(295, 97);
            comboBoxStard.Name = "comboBoxStard";
            comboBoxStard.Size = new Size(183, 46);
            comboBoxStard.TabIndex = 0;
            comboBoxStard.SelectedIndexChanged += comboBoxStard_SelectedIndexChanged_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Zodiac
            // 
            Zodiac.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Zodiac.DataPropertyName = "Zodiac";
            Zodiac.HeaderText = "Зодіакальність";
            Zodiac.MinimumWidth = 9;
            Zodiac.Name = "Zodiac";
            Zodiac.ReadOnly = true;
            Zodiac.Width = 240;
            // 
            // NotableObjects
            // 
            NotableObjects.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NotableObjects.DataPropertyName = "NotableObjects";
            NotableObjects.HeaderText = "Об'єкти сузір'я";
            NotableObjects.MinimumWidth = 9;
            NotableObjects.Name = "NotableObjects";
            NotableObjects.ReadOnly = true;
            NotableObjects.Width = 219;
            // 
            // StarNamesString
            // 
            StarNamesString.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StarNamesString.DataPropertyName = "StarNamesString";
            StarNamesString.HeaderText = "Назви зірок";
            StarNamesString.MinimumWidth = 9;
            StarNamesString.Name = "StarNamesString";
            StarNamesString.ReadOnly = true;
            StarNamesString.Width = 187;
            // 
            // StarCount
            // 
            StarCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StarCount.DataPropertyName = "StarCount";
            StarCount.HeaderText = "Кількість доданих зірок";
            StarCount.MinimumWidth = 9;
            StarCount.Name = "StarCount";
            StarCount.ReadOnly = true;
            StarCount.Width = 259;
            // 
            // AllStars
            // 
            AllStars.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AllStars.DataPropertyName = "AllStars";
            AllStars.HeaderText = "Вся кількість зірок";
            AllStars.MinimumWidth = 9;
            AllStars.Name = "AllStars";
            AllStars.ReadOnly = true;
            AllStars.Width = 257;
            // 
            // Names
            // 
            Names.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Names.DataPropertyName = "Name";
            Names.HeaderText = "Назва";
            Names.MinimumWidth = 9;
            Names.Name = "Names";
            Names.ReadOnly = true;
            Names.Width = 131;
            // 
            // Change
            // 
            Change.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            Change.DefaultCellStyle = dataGridViewCellStyle5;
            Change.HeaderText = "...";
            Change.MinimumWidth = 9;
            Change.Name = "Change";
            Change.Text = "...";
            Change.UseColumnTextForButtonValue = true;
            Change.Width = 41;
            // 
            // colImg
            // 
            colImg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colImg.DataPropertyName = "Image";
            colImg.HeaderText = "Зображення";
            colImg.MinimumWidth = 9;
            colImg.Name = "colImg";
            colImg.ReadOnly = true;
            colImg.Resizable = DataGridViewTriState.True;
            colImg.SortMode = DataGridViewColumnSortMode.Automatic;
            colImg.Width = 174;
            // 
            // colImagePath
            // 
            colImagePath.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colImagePath.DataPropertyName = "ImagePath";
            colImagePath.HeaderText = "";
            colImagePath.MinimumWidth = 9;
            colImagePath.Name = "colImagePath";
            colImagePath.ReadOnly = true;
            colImagePath.Visible = false;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Назва";
            colName.MinimumWidth = 9;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 111;
            // 
            // colCol
            // 
            colCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCol.DataPropertyName = "Color";
            colCol.HeaderText = "Колір";
            colCol.MinimumWidth = 9;
            colCol.Name = "colCol";
            colCol.ReadOnly = true;
            colCol.Width = 106;
            // 
            // colConstellation
            // 
            colConstellation.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colConstellation.DataPropertyName = "Constellation";
            colConstellation.HeaderText = "Сузір'я";
            colConstellation.MinimumWidth = 9;
            colConstellation.Name = "colConstellation";
            colConstellation.ReadOnly = true;
            colConstellation.Width = 119;
            // 
            // colMagnitude
            // 
            colMagnitude.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colMagnitude.DataPropertyName = "ApparentMagnitude";
            colMagnitude.HeaderText = "Зоряна величина";
            colMagnitude.MinimumWidth = 9;
            colMagnitude.Name = "colMagnitude";
            colMagnitude.ReadOnly = true;
            colMagnitude.Width = 203;
            // 
            // colMass
            // 
            colMass.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colMass.DataPropertyName = "Mass";
            colMass.FillWeight = 64F;
            colMass.HeaderText = "Маса (M⊙)";
            colMass.MinimumWidth = 9;
            colMass.Name = "colMass";
            colMass.ReadOnly = true;
            colMass.Width = 148;
            // 
            // colRad
            // 
            colRad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colRad.DataPropertyName = "Radius";
            colRad.HeaderText = "Радіус (R⊙)";
            colRad.MinimumWidth = 9;
            colRad.Name = "colRad";
            colRad.ReadOnly = true;
            colRad.Width = 149;
            // 
            // coldistance
            // 
            coldistance.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            coldistance.DataPropertyName = "Distance";
            coldistance.HeaderText = "Відстань (світ. р)";
            coldistance.MinimumWidth = 9;
            coldistance.Name = "coldistance";
            coldistance.ReadOnly = true;
            coldistance.Width = 177;
            // 
            // colCoordinates
            // 
            colCoordinates.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCoordinates.DataPropertyName = "Coordinates";
            colCoordinates.HeaderText = "Схилення (° ′ ″)";
            colCoordinates.MinimumWidth = 9;
            colCoordinates.Name = "colCoordinates";
            colCoordinates.ReadOnly = true;
            colCoordinates.Width = 163;
            // 
            // ColRightAscension
            // 
            ColRightAscension.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColRightAscension.DataPropertyName = "RightAscension";
            ColRightAscension.HeaderText = "Пряме піднесення (°)";
            ColRightAscension.MinimumWidth = 9;
            ColRightAscension.Name = "ColRightAscension";
            ColRightAscension.ReadOnly = true;
            ColRightAscension.Width = 212;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(2530, 1086);
            Controls.Add(panel1);
            Controls.Add(addStars);
            Controls.Add(constellationInf);
            Name = "Form1";
            Text = "Astronomy_diary";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Add;
        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox boxConstellation;
        private TextBox txtDistance;
        private TextBox txtCoordinates;
        private ComboBox comboBox1;
        private TextBox txtMagnitude;
        private Button addStars;
        private Button constellationInf;
        private Panel panel1;
        private ComboBox comboColor;
        private TextBox txtRadius;
        private TextBox txtMass;
        private PictureBox pbPhoto;
        private PictureBox btnLoadImage;
        private Button btnAddPhoto;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private ComboBox cmbStars;
        private ComboBox comboBoxStard;
        private Button button2;
        private Button btnChange;
        private Button btnSave;
        private TextBox txtSearchAll;
        private Button Search;
        private ComboBox comboSearchBy;
        private Label label5;
        private Panel panel2;
        private DataGridView dataGridView2;
        private Label label6;
        private Label label7;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox sortCriteria;
        private Label label14;
        private TextBox txtRightAscension;
        private TextBox txtLatitude;
        private DateTimePicker dtpObservationTime;
        private TextBox txtLongitude;
        private Button btnVisibleStars;
        private Label label15;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Button btnUnload;
        private Label label20;
        private Label label21;
        private DataGridViewImageColumn colImg;
        private DataGridViewTextBoxColumn colImagePath;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCol;
        private DataGridViewTextBoxColumn colConstellation;
        private DataGridViewTextBoxColumn colMagnitude;
        private DataGridViewTextBoxColumn colMass;
        private DataGridViewTextBoxColumn colRad;
        private DataGridViewTextBoxColumn coldistance;
        private DataGridViewTextBoxColumn colCoordinates;
        private DataGridViewTextBoxColumn ColRightAscension;
        private DataGridViewButtonColumn Change;
        private DataGridViewTextBoxColumn Names;
        private DataGridViewTextBoxColumn AllStars;
        private DataGridViewTextBoxColumn StarCount;
        private DataGridViewTextBoxColumn StarNamesString;
        private DataGridViewTextBoxColumn NotableObjects;
        private DataGridViewTextBoxColumn Zodiac;
    }
}
