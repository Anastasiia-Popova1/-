using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_робота.Models
{
    internal class Constellation
    {
        public static List<Constellation> Constellations = new List<Constellation>();
        public string Name { get; set; }
        public int AllStars { get; set; }

        public int StarCount
        {
            get
            {   
                return Star.Stars
                   .Where(s => s.Constellation == this.Name)
                   .Count();
            }
        }
        public List<string> StarNames { get; set; } = new List<string>();
        public string NotableObjects { get; set; }
        public bool Zodiac { get; set; }


        public static BindingList<Constellation> GetDefaultList()
        {
            string[] names = new string[]
        {
            "Андромеда", "Близнята", "Велика Ведмедиця", "Великий Пес", "Візничий", "Вітрила", "Вовк", "Водолій",
            "Волопас", "Волосся Вероніки", "Ворон", "Геркулес", "Гідра", "Годинник", "Голуб", "Гончі Пси", "Дельфін",
            "Діва", "Дракон", "Ерідан", "Єдиноріг", "Жертовник", "Живописець", "Жираф", "Журавель", "Заєць", "Змієносець",
            "Змія", "Золота Риба", "Індіанець", "Кассіопея", "Кит", "Кіль", "Козеріг", "Компас", "Корма", "Косинець",
            "Лебідь", "Лев", "Летюча Риба", "Лисичка", "Ліра", "Мала Ведмедиця", "Малий Кінь", "Малий Лев", "Малий Пес",
            "Мікроскоп", "Муха", "Насос", "Овен", "Октант", "Орел", "Оріон", "Павич", "Пегас", "Персей", "Південна Гідра",
            "Південна Корона", "Південна Риба", "Південний Трикутник", "Південний Хрест", "Північна Корона", "Піч",
            "Райський Птах", "Рак", "Риби", "Рись", "Різець", "Секстант", "Сітка", "Скорпіон", "Скульптор", "Столова Гора",
            "Стріла", "Стрілець", "Телескоп", "Телець", "Терези", "Трикутник", "Тукан", "Фенікс", "Хамелеон", "Центавр",
            "Цефей", "Циркуль", "Чаша", "Щит", "Ящірка"
        };

            List<string> zodiacNames = new List<string>
            {
                "Овен", "Телець", "Близнята", "Рак", "Лев", "Діва",
                "Терези", "Скорпіон", "Стрілець", "Козеріг", "Водолій", "Риби"
            };

            return new BindingList<Constellation>(
            names.Select(name => new Constellation
            {
                Name = name,
                NotableObjects = "",
                StarNames = new List<string>(),
                Zodiac = zodiacNames.Contains(name)
            }).ToList()
            );
        }

        public static void InitializeData()
        {

            var list = GetDefaultList();

            foreach (var c in list)
            {
                var existing = Constellations.FirstOrDefault(x => x.Name == c.Name);
                if (existing != null)
                {
                    c.AllStars = existing.AllStars;
                    c.NotableObjects = existing.NotableObjects;
                }
            }

            Constellations.Clear();
            Constellations.AddRange(list);
            
            foreach (var constellation in Constellations)
            {
                var matchedStars = Star.Stars
                    .Where(s => s.Constellation == constellation.Name)
                    .Select(s => s.Name)
                    .ToList();
                constellation.StarNames = matchedStars;
            }

        }
        public string StarNamesString
        {
            get => string.Join(", ", StarNames);
            set => StarNames = value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(s => s.Trim())
                                    .ToList();
        }

    }

}
