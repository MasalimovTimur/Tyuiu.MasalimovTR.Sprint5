﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MasalimovTR.Sprint5.Task3.V18.Lib
{
    public class DataService : ISprint5Task3V18
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });

            File.WriteAllText(path, "0;0;0\n1;1;1\n0;0;1");
            return path;
        }
    }
}
