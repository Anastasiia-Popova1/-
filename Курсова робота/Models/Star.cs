using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсова_робота.Services;
namespace Курсова_робота.Models
{
    internal class Star
    {

        public string Name { get; set; }
        public string Constellation { get; set; }
        public double ApparentMagnitude { get; set; }
        public double Distance { get; set; }
        public string Coordinates { get; set; }
        public int RightAscension { get; set; }
        public string Color { get; set; }
        public double Mass { get; set; }
        public double Radius { get; set; }
        public Image Image { get; set; }
        public string ImagePath { get; set; }

        public static List<Star> Stars = new List<Star>();

        public static void AddStar(string name, string constellation, double magnitude, double distance,
                               string coordinates, int rightascension, string color, double mass, double radius, Image image, string imagePath)
        {
            Star star = new Star
            {
                Name = name,
                Constellation = constellation,
                ApparentMagnitude = magnitude,
                Distance = distance,
                Coordinates = coordinates,
                RightAscension = rightascension,
                Color = color,
                Mass = mass,
                Radius = radius,
                Image = image,
                ImagePath = imagePath
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
                   string coordinates, int rightascension, string color, double mass, double radius, Image image, string imagePath)
        {
            this.Name = name;
            this.Constellation = constellation;
            this.ApparentMagnitude = magnitude;
            this.Distance = distance;
            this.Coordinates = coordinates;
            this.RightAscension = rightascension;
            this.Color = color;
            this.Mass = mass;
            this.Radius = radius;
            this.Image = image;
            this.ImagePath = imagePath;
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
                    writer.WriteLine("Пряме піднесення: " + star.RightAscension);
                    writer.WriteLine("Колір: " + star.Color);
                    writer.WriteLine("Маса: " + star.Mass);
                    writer.WriteLine("Радіус: " + star.Radius);
                    writer.WriteLine("Фото: " + (star.Image != null ? "є" : "немає"));
                    writer.WriteLine("Шлях до фото: " + (star.ImagePath ?? "немає"));
                    writer.WriteLine(" ");
                }
            }
        }

        public static void LoadStarsFromFile(string filePath)
        {
            Stars.Clear();
            string[] lines = File.ReadAllLines(filePath);
            Star currentStar = new Star();
            int counter = 0;
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    Stars.Add(currentStar);
                    currentStar = new Star();
                    counter = 0;
                    continue;
                }
                string[] parts = line.Split(new[] { ':' }, 2);
                if (parts.Length < 2) continue;
                string key = parts[0].Trim();
                string value = parts[1].Trim();
                switch (key)
                {
                    case "Назва": currentStar.Name = value; break;
                    case "Сузір'я": currentStar.Constellation = value; break;
                    case "Зоряна величина": currentStar.ApparentMagnitude = double.Parse(value); break;
                    case "Відстань": currentStar.Distance = double.Parse(value); break;
                    case "Координати": currentStar.Coordinates = value; break;
                    case "Пряме піднесення": currentStar.RightAscension = int.Parse(value); break;
                    case "Колір": currentStar.Color = value; break;
                    case "Маса": currentStar.Mass = double.Parse(value); break;
                    case "Радіус": currentStar.Radius = double.Parse(value); break;
                    case "Шлях до фото":
                        currentStar.ImagePath = value == "немає" ? null : value;
                        if (File.Exists(currentStar.ImagePath))
                        {
                            try
                            {
                                using (var img = Image.FromFile(currentStar.ImagePath))
                                {
                                    currentStar.Image = ImageService.ResizeImage(img, 200, 200);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Помилка при відкритті зображення:\n" + ex.Message);
                                currentStar.Image = null;
                            }
                        }
                        break;

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
                (field == "Пряме піднесення" && star.RightAscension.ToString().Contains(value)) ||
                (field == "Координати" && ValidationService.FormatCoordinates(star.Coordinates).Contains(value))
            ).ToList();
            
        }

        public static double ParseDMS(string dmsString)
        {
            var regex = new Regex(@"^\s*(-?\d+)\s*°\s+(\d+)\s*[′']\s+(\d+)\s*[″""]\s*$");
            var match = regex.Match(dmsString);

            int degrees = int.Parse(match.Groups[1].Value);
            int minutes = int.Parse(match.Groups[2].Value);
            int seconds = int.Parse(match.Groups[3].Value);

            double sign = degrees < 0 ? -1 : 1;

            return degrees + sign * (minutes / 60.0) + sign * (seconds / 3600.0);
        }
        public static bool IsSunAboveHorizon(double latitude, double longitude, DateTime utcTime)
        {
            double latRad = DegToRad(latitude);
            double lonRad = DegToRad(longitude);

            double julianDate = GetJulianDate(utcTime);

            double[] solarPos = GetSunPosition(julianDate, lonRad, latRad);
            double sunAltitude = solarPos[0]; 

            return sunAltitude > 0; 
        }
        private static double GetJulianDate(DateTime date)
        {
            return date.ToOADate() + 2415018.5;
        }

        private static double[] GetSunPosition(double julianDate, double lonRad, double latRad)
        {
            double n = julianDate - 2451545.0;

            double L = (280.460 + 0.9856474 * n) % 360;
            if (L < 0) L += 360;

            double g = (357.528 + 0.9856003 * n) % 360;
            if (g < 0) g += 360;
            double gRad = DegToRad(g);

            double lambda = L + 1.915 * Math.Sin(gRad) + 0.020 * Math.Sin(2 * gRad);
            double lambdaRad = DegToRad(lambda);

            double epsilon = 23.439 - 0.0000004 * n;
            double epsilonRad = DegToRad(epsilon);

            double alpha = Math.Atan2(
                Math.Cos(epsilonRad) * Math.Sin(lambdaRad),
                Math.Cos(lambdaRad)
            );
            double delta = Math.Asin(Math.Sin(epsilonRad) * Math.Sin(lambdaRad));

            double GMST = (280.46061837 + 360.98564736629 * n) % 360;
            if (GMST < 0) GMST += 360;
            double LST = DegToRad(GMST) + lonRad;

            double HA = LST - alpha;
            if (HA < 0) HA += 2 * Math.PI;

            double altitude = Math.Asin(
                Math.Sin(latRad) * Math.Sin(delta) +
                Math.Cos(latRad) * Math.Cos(delta) * Math.Cos(HA)
            );

            double azimuth = Math.Atan2(
                Math.Sin(HA),
                Math.Cos(HA) * Math.Sin(latRad) - Math.Tan(delta) * Math.Cos(latRad)
            );
            azimuth += Math.PI; 

            return new double[] {
            RadToDeg(altitude), 
            RadToDeg(azimuth)     
    };

        }
        public static bool IsStarVisible(Star star, double latitude, double longitude, DateTime utcTime)
        {
            if (IsSunAboveHorizon(latitude, longitude, utcTime))
            {
                return false; 
            }

            double ra = star.RightAscension; 
            double dec = ParseDMS(star.Coordinates);

            double lst = CalculateLocalSiderealTime(longitude, utcTime);
            double hourAngle = lst - ra;

            hourAngle = (hourAngle % 360 + 360) % 360;

            double altitude = Math.Asin(
                Math.Sin(DegToRad(dec)) * Math.Sin(DegToRad(latitude)) +
                Math.Cos(DegToRad(dec)) * Math.Cos(DegToRad(latitude)) * Math.Cos(DegToRad(hourAngle))
            );

            double altitudeDeg = RadToDeg(altitude);
            return altitudeDeg > 5;
        }

        public static double CalculateLocalSiderealTime(double longitude, DateTime utc)
        {
            TimeSpan ts = utc - new DateTime(2000, 1, 1, 12, 0, 0, DateTimeKind.Utc);
            double days = ts.TotalDays;

            double lst = 100.46 + 0.985647 * days + longitude;
            return (lst % 360 + 360) % 360;
        }

        private static double DegToRad(double deg) => deg * Math.PI / 180.0;
        private static double RadToDeg(double rad) => rad * 180.0 / Math.PI;

        public static List<Star> sortedStars { get; private set; }
        public static void SortStars(string sortCriteria)
        {
            sortedStars = Stars;

            switch (sortCriteria)
            {
                case "Зірки за алфавітом":
                    sortedStars = Star.Stars.OrderBy(star => star.Name).ToList();
                    break;

                case "Зірки за кольорами":
                    sortedStars = Star.Stars.OrderBy(star => star.Color).ToList();
                    break;

                case "Зірки за сузір'ям":
                    sortedStars = Star.Stars.OrderBy(star => star.Constellation).ThenBy(star => star.Name).ToList();
                    break;

                case "Найяскравіші зірки":
                    sortedStars = Star.Stars.OrderBy(star => star.ApparentMagnitude).ToList();
                    break;

                case "Зірки з найбільшою масою":
                    sortedStars = Star.Stars.OrderByDescending(star => star.Mass).ToList();
                    break;

                case "Найбільші зірки":
                    sortedStars = Star.Stars.OrderByDescending(star => star.Radius).ToList();
                    break;

                case "Найближчі зірки":
                    sortedStars = Star.Stars.OrderBy(star => star.Distance).ToList();
                    break;

                default:
                    sortedStars = Star.Stars.ToList(); 
                    break;
            }
            
        }




    }
}
