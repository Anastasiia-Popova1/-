using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_робота.Services
{
    internal class ValidationService
    {
        public static bool ValidateStarInput(
            TextBox txtName, ComboBox comboBox1, ComboBox comboColor, TextBox txtMagnitude, TextBox txtDistance,
            TextBox txtCoordinates, TextBox txtRightAscension, TextBox txtMass, TextBox txtRadius,
            out double magnitude, out double distance,
            out string formattedCoords, out int rightascension, out double mass, out double radius)
        {
            magnitude = 0;
            distance = 0;
            formattedCoords = "";
            rightascension = 0;
            mass = 0;
            radius = 0;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                Show("Введіть назву зірки."); return false;
            }
            if (string.IsNullOrWhiteSpace(txtRightAscension.Text))
            {
                Show("Введіть пряме піднесення."); return false;
            }
            if (string.IsNullOrWhiteSpace(comboColor.Text))
            {
                Show("Виберіть колір."); return false;
            }
            if (string.IsNullOrWhiteSpace(txtMagnitude.Text) || !double.TryParse(txtMagnitude.Text, out magnitude))
            {
                Show("Введіть коректну зоряну величину."); return false;
            }
            if (string.IsNullOrWhiteSpace(txtDistance.Text) || !double.TryParse(txtDistance.Text, out distance) || distance < 0)
            {
                Show("Введіть коректну відстань."); return false;
            }
            if (string.IsNullOrWhiteSpace(txtCoordinates.Text))
            {
                Show("Введіть схилення."); return false;
            }

            string[] parts = txtCoordinates.Text.Split(',');
            if (parts.Length != 3 ||
                !int.TryParse(parts[0].Trim(), out int h) ||
                !int.TryParse(parts[1].Trim(), out int m) ||
                !int.TryParse(parts[2].Trim(), out int s))
                
            {
                Show("Схилення повинно бути у форматі: градуси, хвилини, секунди (наприклад: 79, 59, 59)"); return false;
            }
            if(h > 90 || h < -90 || m > 59 || m < 0 || s > 59 || s < 0 || (h == 90 && m + s > 0))
            {
                Show("Схилення приймае невірне значення"); return false;
            }

            formattedCoords = $"{h}° {m}′ {s}″";

            if (!double.TryParse(txtMass.Text, out mass) || mass < 0)
            {
                Show("Введіть коректну масу."); return false;
            }
            if (!double.TryParse(txtRadius.Text, out radius) || radius < 0)
            {
                Show("Введіть коректний радіус."); return false;
            }
            if (!int.TryParse(txtRightAscension.Text, out rightascension) || rightascension < 1 || rightascension > 360)
            {
                Show("Введіть коректне пряме піднесення."); return false;
            }

            return true;
        }
        private static void Show(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static string FormatCoordinates(string coordinates)
        {
            return coordinates
                .ToLower()
                .Replace("°", "")
                .Replace("′", "")
                .Replace("″", "")
                .Replace("  ", " ")
                .Trim()
                .Replace(" ", ",");
        }
        public static bool TryGetCoordinates(TextBox txtLatitude, TextBox txtLongitude, out double latitude, out double longitude)
        {
            latitude = 0;
            longitude = 0;

            if (string.IsNullOrWhiteSpace(txtLatitude.Text))
            {
                MessageBox.Show("Введіть широту."); return false;
            }
            if (string.IsNullOrWhiteSpace(txtLongitude.Text))
            {
                MessageBox.Show("Введіть довготу."); return false;
            }
            if (!double.TryParse(txtLatitude.Text, out latitude) || latitude < -90 || latitude > 90)
            {
                MessageBox.Show("Введіть коректну широту (від -90 до 90 градусів).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtLongitude.Text, out longitude) || longitude < -180 || longitude > 180)
            {
                MessageBox.Show("Введіть коректну довготу (від -180 до 180 градусів).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


    }
}
