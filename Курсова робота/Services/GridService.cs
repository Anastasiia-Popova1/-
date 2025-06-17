using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсова_робота.Models;

namespace Курсова_робота.Services
{
    internal class GridService
    {
        public static void FormatConstellationGrid(DataGridView grid)
        {
            grid.DataSource = Constellation.Constellations;

            grid.CellFormatting -= Grid_CellFormatting;
            grid.CellFormatting += Grid_CellFormatting;
        }
        private static void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid == null)
                return;

            if (grid.Columns[e.ColumnIndex].Name == "StarCount")
            {
                if (e.Value is int starCount && starCount == 0)
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
            else if (grid.Columns[e.ColumnIndex].Name == "Zodiac")
            {
                if (e.Value is bool zodiac)
                {
                    e.Value = zodiac ? "Так" : "Ні";
                    e.FormattingApplied = true;
                }
            }
            else if (grid.Columns[e.ColumnIndex].Name == "StarNames")
            {
                if (e.Value is List<string> starNames)
                {
                    e.Value = string.Join(", ", starNames);
                    e.FormattingApplied = true;
                }
            }
            if (grid.Columns[e.ColumnIndex].Name == "AllStars")
            {
                if (e.Value is int starCount && starCount == 0)
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
