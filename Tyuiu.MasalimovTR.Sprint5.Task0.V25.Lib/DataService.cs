﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Diagnostics;

namespace Tyuiu.MasalimovTR.Sprint5.Task0.V25.Lib
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {
            string Path = $@"{Directory.GetCurrentDirectory()}";            
            double y = Math.Round((3 * Math.Pow(x, 4) + 1)/Math.Pow(x, 3), 3);
            File.WriteAllText(Path, Convert.ToString(y));
            return Path;
        }
    }
}
