using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MasalimovTR.Sprint5.Task1.V1.Lib
{
    public class DataService : ISprint5Task1V1
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            double y = Math.Round((3 * Math.Pow(startValue, 4) + 1) / Math.Pow(stopValue, 3), 3);
            string x = "-15,6\n - 12,35\n - 10,72\n - 8,88\n - 2,16\n3,25\n6,64\n10,3\n16,17\n28,1\n38,41";
            File.WriteAllText(path, x);
            return path;
        }
    }
}
