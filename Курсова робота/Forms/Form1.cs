using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Linq;
using Курсова_робота.Models;
using Курсова_робота.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Курсова_робота
{
    public partial class Form1 : Form
    {
        private string imagePath;
        private Image resizedImage;
        private Star selectedStar;
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            Constellation.InitializeData();
            dataGridView2.DataSource = new BindingList<Constellation>(Constellation.Constellations);
            panel1.Visible = true;
            panel2.Visible = false;
            dataGridView2.DataError += dataGridView2_DataError;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridService.FormatConstellationGrid(dataGridView2);
        }


        private void addStars_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void InitializeGrid()
        {
            dataGridView1.DataSource = Star.Stars;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (selectedStar != null)
            {
                MessageBox.Show("Спочатку змініть зірку.");
                return;
            }
            if (!ValidationService.ValidateStarInput(
        txtName, comboBox1, comboColor, txtMagnitude, txtDistance,
        txtCoordinates, txtRightAscension, txtMass, txtRadius,
        out double magnitude, out double distance,
        out string formattedCoords, out int rightascension, out double mass, out double radius))
            {
                return;
            }
            Star.AddStar(
            txtName.Text,
            comboBox1.Text,
            double.Parse(txtMagnitude.Text),
            double.Parse(txtDistance.Text),
            formattedCoords,
            int.Parse(txtRightAscension.Text),
            comboColor.Text,
            double.Parse(txtMass.Text),
            double.Parse(txtRadius.Text),
            resizedImage,
            this.imagePath
            );

            RefreshGrid();
            UpdateComboBoxStars();
            UpdateComboBoxStars2();
            Constellation.InitializeData();
            GridService.FormatConstellationGrid(dataGridView2);

            FormCleaner.ClearStarForm(
            txtName, txtMagnitude, txtDistance, txtMass, txtRadius, txtCoordinates, txtRightAscension,
            label1, label2, pbPhoto, ref resizedImage, ref imagePath);
        }
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Star.Stars;
            dataGridView1.ClearSelection();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.imagePath = openFileDialog1.FileName;
                    using (Image originalImage = Image.FromFile(this.imagePath))
                    {
                        this.resizedImage = ImageService.ResizeImage(originalImage, 200, 200);
                        pbPhoto.Image = this.resizedImage;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження зображень: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        private void UpdateComboBoxStars()
        {
            comboBoxStard.Items.Clear();
            var starNames = Star.Stars.Select(s => s.Name).Distinct().ToList();
            comboBoxStard.Items.AddRange(starNames.ToArray());
        }
        private void UpdateComboBoxStars2()
        {
            cmbStars.Items.Clear();
            var starNames = Star.Stars.Select(s => s.Name).Distinct().ToList();
            cmbStars.Items.AddRange(starNames.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            string? selectedName = comboBoxStard.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedName))
            {
                return;
            }
            if (string.IsNullOrEmpty(selectedName))
                return;

            DialogResult result = MessageBox.Show($"Точно видалити зірку '{selectedName}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Star.DeletedByName(selectedName);

                RefreshGrid();
                UpdateComboBoxStars();
                UpdateComboBoxStars2();
                Constellation.InitializeData();
                GridService.FormatConstellationGrid(dataGridView2);
                comboBoxStard.SelectedIndex = -1;
            }
        }
        private void comboBoxStard_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void cmbStars_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = false;

            string? selectedName = cmbStars.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedName))
                return;

            selectedStar = Star.Stars.FirstOrDefault(s => s.Name == selectedName);
            if (selectedStar == null)
                return;
            label1.Visible = false;
            label2.Visible = false;
            txtName.Text = selectedStar.Name;
            txtMagnitude.Text = selectedStar.ApparentMagnitude.ToString();
            txtMass.Text = selectedStar.Mass.ToString();
            string cleaned = Regex.Replace(selectedStar.Coordinates, @"[°′″]", "").Trim();
            string formatted = Regex.Replace(cleaned, @"\s+", ", ");
            txtCoordinates.Text = formatted;
            txtRightAscension.Text = selectedStar.RightAscension.ToString();
            txtDistance.Text = selectedStar.Distance.ToString();
            txtRadius.Text = selectedStar.Radius.ToString();
            comboColor.Text = selectedStar.Color;
            comboBox1.Text = selectedStar.Constellation;
            pbPhoto.Image = selectedStar.Image;
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (selectedStar == null)
            {
                MessageBox.Show("Виберіть зірку для зміни");
                return;
            }

            if (!ValidationService.ValidateStarInput(
                txtName, comboBox1, comboColor, txtMagnitude, txtDistance,
                txtCoordinates, txtRightAscension, txtMass, txtRadius,
                out double magnitude, out double distance,
                out string formattedCoords, out int rightascensionout, out double mass, out double radius))
            {
                return;
            }
            label3.Visible = true;
            selectedStar.Update(
                txtName.Text,
                comboBox1.Text,
                double.Parse(txtMagnitude.Text),
                double.Parse(txtDistance.Text),
                formattedCoords,
                int.Parse(txtRightAscension.Text),
                comboColor.Text,
                double.Parse(txtMass.Text),
                double.Parse(txtRadius.Text),
                pbPhoto.Image,
                this.imagePath
            );

            FormCleaner.ClearStarForm(
            txtName, txtMagnitude, txtDistance, txtMass, txtRadius, txtCoordinates, txtRightAscension,
            label1, label2, pbPhoto, ref resizedImage, ref imagePath);

            RefreshGrid();
            UpdateComboBoxStars();
            UpdateComboBoxStars2();
            Constellation.InitializeData();
            GridService.FormatConstellationGrid(dataGridView2);
            cmbStars.SelectedIndex = -1;
            selectedStar = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Зберегти дані про зірки";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Star.SaveStarsToFile(saveFileDialog.FileName);
                    MessageBox.Show("Дані збережено успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void Search_Click(object sender, EventArgs e)
        {

            string? selectedField = comboSearchBy.SelectedItem?.ToString();
            string searchText = txtSearchAll.Text;

            if (string.IsNullOrEmpty(selectedField) || string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Оберіть параметр і введіть значення.");
                return;
            }

            var foundStars = Star.SearchStars(selectedField, searchText);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = foundStars;

            if (foundStars.Count == 0)
                MessageBox.Show("Нічого не знайдено.");
            label5.Visible = true;
        }

        private void comboSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            label20.Visible = false;
        }

        private void btnVisibleStars_Click(object sender, EventArgs e)
        {
            if (!ValidationService.TryGetCoordinates(txtLatitude, txtLongitude, out double latitude, out double longitude))
                return;

            latitude = double.Parse(txtLatitude.Text, CultureInfo.InvariantCulture);
            longitude = double.Parse(txtLongitude.Text, CultureInfo.InvariantCulture);
            DateTime dateTime = dtpObservationTime.Value.ToUniversalTime();
            var visibleStars = Star.Stars
                .Where(star => Star.IsStarVisible(star, latitude, longitude, dateTime))
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = visibleStars;

            if (visibleStars.Count == 0)
            {
                MessageBox.Show("Немає видимих зірок у цей момент з даної точки.");
            }
        }

        private void sortCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            label21.Visible = false;
            if (sortCriteria.SelectedItem == null) return;

            Star.SortStars(sortCriteria.SelectedItem.ToString());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Star.sortedStars;

        }
        private void btnUnload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Title = "Виберіть файл для завантаження";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Star.LoadStarsFromFile(openFileDialog.FileName);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Star.Stars;
                    UpdateComboBoxStars();
                    UpdateComboBoxStars2();
                    Constellation.InitializeData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void constellationInf_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView2.Rows[e.RowIndex];
            string columnName = dataGridView2.Columns[e.ColumnIndex].Name;

            if (columnName == "AllStars")
            {
                string? value = row.Cells["AllStars"].Value?.ToString();

                if (!int.TryParse(value, out int starCount))
                {
                    MessageBox.Show("Введіть ціле число для кількості зірок.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    row.Cells["AllStars"].Value = 0;
                    return;
                }

                string? name = row.Cells["Name"].Value?.ToString();
                var constellation = Constellation.Constellations.FirstOrDefault(c => c.Name == name);
                if (constellation != null)
                {
                    constellation.AllStars = starCount;
                }
            }
            if (columnName == "NotableObjects")
            {
                string? name = row.Cells["Name"].Value?.ToString();
                string notableObjects = row.Cells["NotableObjects"].Value?.ToString() ?? "";

                var constellation = Constellation.Constellations.FirstOrDefault(c => c.Name == name);
                if (constellation != null)
                {
                    constellation.NotableObjects = notableObjects;
                }
            }
            dataGridView2.EndEdit();
            row.Cells["AllStars"].ReadOnly = true;
            row.Cells["NotableObjects"].ReadOnly = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Change"].Index && e.RowIndex >= 0)
            {
                var row = dataGridView2.Rows[e.RowIndex];

                row.Cells["AllStars"].ReadOnly = false;
                row.Cells["NotableObjects"].ReadOnly = false;
            }
        }
        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "AllStars")
            {
                MessageBox.Show("Введіть ціле число для кількості зірок.", "Помилка формату", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                e.Cancel = false;
            }
        }
    }
}
