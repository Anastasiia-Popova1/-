using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_робота.Models
{
    internal class Star
    {

        public string Name { get; set; }
        public string Constellation { get; set; }
        public double ApparentMagnitude { get; set; }
        public double Distance { get; set; }
        public string Coordinates { get; set; }
        public string Color { get; set; }
        public double Mass { get; set; }
        public double Radius { get; set; }
        public Image Image { get; set; }

        public static List<Star> Stars = new List<Star>();

        public static void AddStar(string name, string constellation, double magnitude, double distance,
                               string coordinates, string color, double mass, double radius, Image image)
        {
            Star star = new Star
            {
                Name = name,
                Constellation = constellation,
                ApparentMagnitude = magnitude,
                Distance = distance,
                Coordinates = coordinates,
                Color = color,
                Mass = mass,
                Radius = radius,
                Image = image
            };

            Star.AddStar(star);
        }

        public static void AddStar(Star star)
        {
            Stars.Add(star);
        }

        public static bool DeletedByName(string name)
        {
            int count = Stars.RemoveAll(s => s.Name == name);
            return count > 0;
        }

        public void Update(string name, string constellation, double magnitude, double distance,
                   string coordinates, string color, double mass, double radius, Image image)
        {
            this.Name = name;
            this.Constellation = constellation;
            this.ApparentMagnitude = magnitude;
            this.Distance = distance;
            this.Coordinates = coordinates;
            this.Color = color;
            this.Mass = mass;
            this.Radius = radius;
            this.Image = image;
        }

        public static void SaveStarsToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var star in Stars)
                {
                    writer.WriteLine("Назва: " + star.Name);
                    writer.WriteLine("Сузір'я: " + star.Constellation);
                    writer.WriteLine("Зоряна величина: " + star.ApparentMagnitude);
                    writer.WriteLine("Відстань: " + star.Distance);
                    writer.WriteLine("Координати: " + star.Coordinates);
                    writer.WriteLine("Колір: " + star.Color);
                    writer.WriteLine("Маса: " + star.Mass);
                    writer.WriteLine("Радіус: " + star.Radius);
                    writer.WriteLine("Фото: " + (star.Image != null ? "є" : "немає"));
                    writer.WriteLine(" ");
                }
            }
        }
        public static List<Star> SearchStars(string field, string value)
        {  
            value = value.ToLower().Trim();
            if (field == "Всі")
            {
                return Stars;
            }
            return Stars.Where(star =>
                (field == "Назва" && star.Name.ToLower().Contains(value)) ||
                (field == "Колір" && star.Color.ToLower().Contains(value)) ||
                (field == "Сузір'я" && star.Constellation.ToLower().Contains(value)) ||
                (field == "Зоряна величина" && star.ApparentMagnitude.ToString().Contains(value)) ||
                (field == "Відстань" && star.Distance.ToString().Contains(value)) ||
                (field == "Маса" && star.Mass.ToString().Contains(value)) ||
                (field == "Радіус" && star.Radius.ToString().Contains(value)) ||
                (field == "Координати" && FormatCoordinates(star.Coordinates).Contains(value))
            ).ToList();
            
        }

    }

}
