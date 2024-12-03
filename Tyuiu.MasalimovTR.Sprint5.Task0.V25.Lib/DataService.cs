using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MasalimovTR.Sprint5.Task0.V25.Lib
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {
            string executablePath = AppContext.BaseDirectory;
            string textPath = Path.Combine(executablePath, "OutPutFileTask0.txt"); ;
            double y = Math.Round((3 * Math.Pow(x, 4) + 1)/Math.Pow(x, 3), 3);
            File.WriteAllText(textPath, Convert.ToString(y));
            return textPath;
        }
    }
}
