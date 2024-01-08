using ItemLibraray.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibraray.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string fullFilePath(this string fileName) // ItemModels.csv
        {
            return $"{ ConfigurationManager.AppSettings["filepath"] }\\{ fileName } ";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadLines(file).ToList();
        }

        public static List<ItemModel> ConvertToItemModels(this List<string> lines)
        {
            List<ItemModel> output = new List<ItemModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ItemModel p = new ItemModel(cols[1], cols[2], cols[3], cols[4]);
                p.ID = int.Parse(cols[0]);
                output.Add(p);
            }

            return output;
        }

        public static void SaveToItemFile(this List<ItemModel> p_Models, string p_FileName)
        {
            List<string> lines = new List<string>();

            foreach (ItemModel item in p_Models)
            {
                lines.Add($"{ item.ID }, { item.Name }, { item.Description }, { item.Value }, { item.Lore }");
            }

            File.WriteAllLines(p_FileName.fullFilePath(), lines);
        }
    }
}
