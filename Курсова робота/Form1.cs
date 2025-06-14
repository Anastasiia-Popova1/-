using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Linq;
using Курсова_робота.Models;

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
            panel1.Visible = true;
            panel2.Visible = false;
            //panel3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void addStars_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            //panel3.Visible = false;
        }

        private void InitializeGrid()
        {
            dataGridView1.DataSource = Star.Stars;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введіть назву зірки.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Виберіть сузір’я.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrWhiteSpace(txtMagnitude.Text))
            {
                MessageBox.Show("Введіть зоряну величину.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtMagnitude.Text, out double magnitude))
            {
                MessageBox.Show("Введіть коректну зоряну величину.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDistance.Text))
            {
                MessageBox.Show("Введіть відстань.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtDistance.Text, out double distance))
            {
                MessageBox.Show("Введіть коректну відстань.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (distance < 0)
            {
                MessageBox.Show("Відстань не може бути від’ємною.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCoordinates.Text))
            {
                MessageBox.Show("Введіть координати.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string rawCoords = txtCoordinates.Text;
            string[] parts = rawCoords.Split(',');

            if (parts.Length != 3 ||
                !int.TryParse(parts[0].Trim(), out int h) ||
                !int.TryParse(parts[1].Trim(), out int m) ||
                !int.TryParse(parts[2].Trim(), out int s))
            {
                MessageBox.Show("Координати повинні бути у форматі: години, хвилини, секунди (наприклад: 23, 59, 59)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (h > 24 || m > 59 || s > 59 || h == 24 && m + s > 0)
            {
                MessageBox.Show("Невірні значення координат", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string formattedCoords = $"{h}° {m}′ {s}″";

            if (!double.TryParse(txtMass.Text, out double mass))
            {
                MessageBox.Show("Введіть коректну масу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtRadius.Text, out double radius))
            {
                MessageBox.Show("Введіть коректний радіус.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Star.AddStar(
            txtName.Text,
            comboBox1.Text,
            double.Parse(txtMagnitude.Text),
            double.Parse(txtDistance.Text),
            formattedCoords,
            comboColor.Text,
            double.Parse(txtMass.Text),
            double.Parse(txtRadius.Text),
            resizedImage
            );

            RefreshGrid();
            UpdateComboBoxStars();
            UpdateComboBoxStars2();

            txtName.Text = "";
            txtMagnitude.Text = "";
            txtDistance.Text = "";
            txtMass.Text = "";
            txtRadius.Text = "";
            txtCoordinates.Text = "";
            label1.Visible = true;
            label2.Visible = true;
            pbPhoto.Image = null;
            this.resizedImage = null;
            this.imagePath = null;
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
                        this.resizedImage = ResizeImage(originalImage, 150, 150);
                        pbPhoto.Image = this.resizedImage;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження зображень: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            int newWidth;
            int newHeight;
            if (image.Width > image.Height)
            {
                newWidth = maxWidth;
                newHeight = (int)(image.Height * ((float)maxWidth / image.Width));
            }
            else
            {
                newHeight = maxHeight;
                newWidth = (int)(image.Width * ((float)maxHeight / image.Height));
            }
            if (image.Width <= maxWidth && image.Height <= maxHeight)
            {
                return new Bitmap(image);
            }

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return resizedImage;
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
            string selectedName = comboBoxStard.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedName))
                return;

            DialogResult result = MessageBox.Show($"Точно видалити зірку '{selectedName}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Star.DeletedByName(selectedName);

                RefreshGrid();
                UpdateComboBoxStars();
                UpdateComboBoxStars2();

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

            string selectedName = cmbStars.SelectedItem?.ToString();
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
            txtDistance.Text = selectedStar.Distance.ToString();
            txtRadius.Text = selectedStar.Radius.ToString();
            comboColor.Text = selectedStar.Color;
            comboBox1.Text = selectedStar.Constellation;
            pbPhoto.Image = selectedStar.Image;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введіть назву зірки.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Виберіть сузір’я.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrWhiteSpace(txtMagnitude.Text))
            {
                MessageBox.Show("Введіть зоряну величину.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtMagnitude.Text, out double magnitude))
            {
                MessageBox.Show("Введіть коректну зоряну величину.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDistance.Text))
            {
                MessageBox.Show("Введіть відстань.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtDistance.Text, out double distance))
            {
                MessageBox.Show("Введіть коректну відстань.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (distance < 0)
            {
                MessageBox.Show("Відстань не може бути від’ємною.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCoordinates.Text))
            {
                MessageBox.Show("Введіть координати.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string rawCoords = txtCoordinates.Text;
            string[] parts = rawCoords.Split(',');
            if (
                !int.TryParse(parts[0].Trim(), out int h) ||
                !int.TryParse(parts[1].Trim(), out int m) ||
                !int.TryParse(parts[2].Trim(), out int s))
            {
                MessageBox.Show("Координати повинні бути у форматі: години, хвилини, секунди (наприклад: 23, 59, 59)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (h > 24 || m > 59 || s > 59 || h == 24 && m + s > 0)
            {
                MessageBox.Show("Невірні значення координат", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string formattedCoords = $"{h}° {m}′ {s}″";


            if (!double.TryParse(txtMass.Text, out double mass))
            {
                MessageBox.Show("Введіть коректну масу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtRadius.Text, out double radius))
            {
                MessageBox.Show("Введіть коректний радіус.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            label3.Visible = true;
            selectedStar.Update(
                txtName.Text,
                comboBox1.Text,
                double.Parse(txtMagnitude.Text),
                double.Parse(txtDistance.Text),
                formattedCoords,
                comboColor.Text,
                double.Parse(txtMass.Text),
                double.Parse(txtRadius.Text),
                pbPhoto.Image
            );
            txtName.Text = "";
            txtMagnitude.Text = "";
            txtDistance.Text = "";
            txtMass.Text = "";
            txtRadius.Text = "";
            txtCoordinates.Text = "";
            label1.Visible = true;
            label2.Visible = true;
            pbPhoto.Image = null;
            this.resizedImage = null;
            this.imagePath = null;

            RefreshGrid();
            UpdateComboBoxStars();
            UpdateComboBoxStars2();
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

            string selectedField = comboSearchBy.SelectedItem?.ToString();
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
            label5.Visible = false;
        }

        private void constellationInf_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            //panel3.Visible = false;
        }


    }
}
