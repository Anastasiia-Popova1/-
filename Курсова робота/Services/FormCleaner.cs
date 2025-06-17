using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_робота.Services
{
    internal class FormCleaner
    {
        public static void ClearStarForm(
            TextBox txtName,
            TextBox txtMagnitude,
            TextBox txtDistance,
            TextBox txtMass,
            TextBox txtRadius,
            TextBox txtCoordinates,
            TextBox txtRightAscension,
            Label label1,
            Label label2,
            PictureBox pbPhoto,
            ref Image resizedImage,
            ref string imagePath)
        {
            txtName.Text = "";
            txtMagnitude.Text = "";
            txtDistance.Text = "";
            txtMass.Text = "";
            txtRadius.Text = "";
            txtCoordinates.Text = "";
            txtRightAscension.Text = "";
            pbPhoto.Image = null;
            resizedImage = null;
            imagePath = null;
            label1.Visible = true;
            label2.Visible = true;
        }
    }
}
