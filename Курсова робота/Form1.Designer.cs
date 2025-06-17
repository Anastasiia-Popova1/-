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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Add = new Button();
            dataGridView1 = new DataGridView();
            colImg = new DataGridViewImageColumn();
            colName = new DataGridViewTextBoxColumn();
            colCol = new DataGridViewTextBoxColumn();
            colConstellation = new DataGridViewTextBoxColumn();
            colMagnitude = new DataGridViewTextBoxColumn();
            colMass = new DataGridViewTextBoxColumn();
            colRad = new DataGridViewTextBoxColumn();
            coldistance = new DataGridViewTextBoxColumn();
            colCoordinates = new DataGridViewTextBoxColumn();
            txtName = new TextBox();
            txtDistance = new TextBox();
            txtCoordinates = new TextBox();
            comboBox1 = new ComboBox();
            txtMagnitude = new TextBox();
            addStars = new Button();
            constellationInf = new Button();
            calendar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            Names = new DataGridViewTextBoxColumn();
            Hermisphere = new DataGridViewTextBoxColumn();
            StarCount = new DataGridViewTextBoxColumn();
            StarNames = new DataGridViewTextBoxColumn();
            NotableObjects = new DataGridViewTextBoxColumn();
            Zodiac = new DataGridViewTextBoxColumn();
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
            Add.Location = new Point(32, 38);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colImg, colName, colCol, colConstellation, colMagnitude, colMass, colRad, coldistance, colCoordinates });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(612, 114);
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
            dataGridView1.Size = new Size(1447, 629);
            dataGridView1.TabIndex = 6;
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
            colCoordinates.HeaderText = "Координати (° ′ ″)";
            colCoordinates.MinimumWidth = 9;
            colCoordinates.Name = "colCoordinates";
            colCoordinates.ReadOnly = true;
            colCoordinates.Width = 184;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.InactiveCaptionText;
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(32, 216);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Назва";
            txtName.Size = new Size(224, 42);
            txtName.TabIndex = 7;
            // 
            // txtDistance
            // 
            txtDistance.BackColor = SystemColors.InactiveCaptionText;
            txtDistance.Font = new Font("Segoe UI", 11F);
            txtDistance.ForeColor = SystemColors.InactiveBorder;
            txtDistance.Location = new Point(32, 387);
            txtDistance.Name = "txtDistance";
            txtDistance.PlaceholderText = "Відстань";
            txtDistance.Size = new Size(224, 42);
            txtDistance.TabIndex = 10;
            // 
            // txtCoordinates
            // 
            txtCoordinates.BackColor = SystemColors.InactiveCaptionText;
            txtCoordinates.Font = new Font("Segoe UI", 11F);
            txtCoordinates.ForeColor = SystemColors.InactiveBorder;
            txtCoordinates.Location = new Point(32, 301);
            txtCoordinates.Name = "txtCoordinates";
            txtCoordinates.PlaceholderText = "Координати";
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
            comboBox1.Location = new Point(308, 473);
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
            txtMagnitude.Location = new Point(308, 216);
            txtMagnitude.Name = "txtMagnitude";
            txtMagnitude.PlaceholderText = "Зоряна величина";
            txtMagnitude.Size = new Size(224, 42);
            txtMagnitude.TabIndex = 8;
            // 
            // addStars
            // 
            addStars.BackColor = Color.DarkSlateBlue;
            addStars.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addStars.ForeColor = SystemColors.Control;
            addStars.Location = new Point(486, 55);
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
            constellationInf.Location = new Point(876, 55);
            constellationInf.Name = "constellationInf";
            constellationInf.Size = new Size(333, 66);
            constellationInf.TabIndex = 14;
            constellationInf.Text = "Сузір'я";
            constellationInf.UseVisualStyleBackColor = false;
            constellationInf.Click += constellationInf_Click;
            // 
            // calendar
            // 
            calendar.BackColor = Color.DarkSlateBlue;
            calendar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            calendar.ForeColor = SystemColors.Control;
            calendar.Location = new Point(1262, 55);
            calendar.Name = "calendar";
            calendar.Size = new Size(333, 66);
            calendar.TabIndex = 15;
            calendar.Text = "Календар";
            calendar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel2);
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
            panel1.Location = new Point(-4, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(2068, 810);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dataGridView2);
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(2068, 807);
            panel2.TabIndex = 36;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.5F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Names, Hermisphere, StarCount, StarNames, NotableObjects, Zodiac });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.5F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle5.SelectionBackColor = Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.GridColor = SystemColors.ControlLightLight;
            dataGridView2.Location = new Point(349, 152);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.5F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.Size = new Size(1458, 608);
            dataGridView2.TabIndex = 0;
            // 
            // Names
            // 
            Names.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Names.DataPropertyName = "Name";
            Names.HeaderText = "Назва";
            Names.MinimumWidth = 9;
            Names.Name = "Names";
            Names.Width = 131;
            // 
            // Hermisphere
            // 
            Hermisphere.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Hermisphere.DataPropertyName = "Hemisphere";
            Hermisphere.HeaderText = "Півкуля";
            Hermisphere.MinimumWidth = 9;
            Hermisphere.Name = "Hermisphere";
            Hermisphere.Width = 152;
            // 
            // StarCount
            // 
            StarCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StarCount.DataPropertyName = "StarCount";
            StarCount.HeaderText = "Кількість зірок";
            StarCount.MinimumWidth = 9;
            StarCount.Name = "StarCount";
            StarCount.Width = 237;
            // 
            // StarNames
            // 
            StarNames.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StarNames.DataPropertyName = "StarNames";
            StarNames.HeaderText = "Назви зірок";
            StarNames.MinimumWidth = 9;
            StarNames.Name = "StarNames";
            StarNames.Width = 204;
            // 
            // NotableObjects
            // 
            NotableObjects.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NotableObjects.DataPropertyName = "NotableObjects";
            NotableObjects.HeaderText = "Об'єкти сузір'я";
            NotableObjects.MinimumWidth = 9;
            NotableObjects.Name = "NotableObjects";
            NotableObjects.Width = 239;
            // 
            // Zodiac
            // 
            Zodiac.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Zodiac.DataPropertyName = "Zodiac";
            Zodiac.HeaderText = "Зодіакальність";
            Zodiac.MinimumWidth = 9;
            Zodiac.Name = "Zodiac";
            Zodiac.Width = 240;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(952, 39);
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
            comboSearchBy.Items.AddRange(new object[] { "Назва", "Колір", "Сузір'я", "Зоряна величина", "Координати", "Відстань", "Маса", "Радіус", "Всі" });
            comboSearchBy.Location = new Point(950, 38);
            comboSearchBy.Name = "comboSearchBy";
            comboSearchBy.Size = new Size(256, 39);
            comboSearchBy.TabIndex = 34;
            comboSearchBy.SelectedIndexChanged += comboSearchBy_SelectedIndexChanged;
            // 
            // txtSearchAll
            // 
            txtSearchAll.BackColor = SystemColors.InactiveCaptionText;
            txtSearchAll.Font = new Font("Segoe UI", 11F);
            txtSearchAll.ForeColor = SystemColors.InactiveBorder;
            txtSearchAll.Location = new Point(612, 37);
            txtSearchAll.Name = "txtSearchAll";
            txtSearchAll.PlaceholderText = "Пошук";
            txtSearchAll.Size = new Size(306, 42);
            txtSearchAll.TabIndex = 33;
            // 
            // Search
            // 
            Search.BackColor = SystemColors.GradientInactiveCaption;
            Search.Font = new Font("Segoe UI", 9F);
            Search.Location = new Point(1252, 31);
            Search.Name = "Search";
            Search.Size = new Size(49, 46);
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
            btnSave.Location = new Point(32, 109);
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
            button2.Location = new Point(524, 38);
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
            btnChange.Location = new Point(524, 111);
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
            label4.Location = new Point(315, 41);
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
            label3.Location = new Point(315, 114);
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
            cmbStars.Location = new Point(314, 111);
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
            label2.Location = new Point(310, 474);
            label2.Name = "label2";
            label2.Size = new Size(187, 36);
            label2.TabIndex = 23;
            label2.Text = "Сузір'я             ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(34, 473);
            label1.Name = "label1";
            label1.Size = new Size(185, 36);
            label1.TabIndex = 22;
            label1.Text = "Колір               ";
            // 
            // pbPhoto
            // 
            pbPhoto.BackColor = SystemColors.ActiveCaptionText;
            pbPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbPhoto.Location = new Point(308, 543);
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
            btnAddPhoto.Location = new Point(37, 627);
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
            txtRadius.Location = new Point(308, 387);
            txtRadius.Name = "txtRadius";
            txtRadius.PlaceholderText = "Радіус";
            txtRadius.Size = new Size(224, 42);
            txtRadius.TabIndex = 19;
            // 
            // txtMass
            // 
            txtMass.BackColor = SystemColors.InactiveCaptionText;
            txtMass.Font = new Font("Segoe UI", 11F);
            txtMass.ForeColor = SystemColors.InactiveBorder;
            txtMass.Location = new Point(308, 301);
            txtMass.Name = "txtMass";
            txtMass.PlaceholderText = "Маса";
            txtMass.Size = new Size(224, 42);
            txtMass.TabIndex = 18;
            // 
            // comboColor
            // 
            comboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboColor.Font = new Font("Segoe UI", 10F);
            comboColor.FormattingEnabled = true;
            comboColor.Items.AddRange(new object[] { "Голубий", "Біло-голубий", "Білий", "Жовто-білий", "Жовтий", "Оранжевий", "Червоний" });
            comboColor.Location = new Point(32, 472);
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
            comboBoxStard.Location = new Point(314, 38);
            comboBoxStard.Name = "comboBoxStard";
            comboBoxStard.Size = new Size(183, 46);
            comboBoxStard.TabIndex = 0;
            comboBoxStard.SelectedIndexChanged += comboBoxStard_SelectedIndexChanged_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(2067, 972);
            Controls.Add(panel1);
            Controls.Add(addStars);
            Controls.Add(constellationInf);
            Controls.Add(calendar);
            Name = "Form1";
            Text = "Form1";
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
        private Button calendar;
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
        private DataGridViewImageColumn colImg;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCol;
        private DataGridViewTextBoxColumn colConstellation;
        private DataGridViewTextBoxColumn colMagnitude;
        private DataGridViewTextBoxColumn colMass;
        private DataGridViewTextBoxColumn colRad;
        private DataGridViewTextBoxColumn coldistance;
        private DataGridViewTextBoxColumn colCoordinates;
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
        private DataGridViewTextBoxColumn Names;
        private DataGridViewTextBoxColumn Hermisphere;
        private DataGridViewTextBoxColumn StarCount;
        private DataGridViewTextBoxColumn StarNames;
        private DataGridViewTextBoxColumn NotableObjects;
        private DataGridViewTextBoxColumn Zodiac;
    }
}
