using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MasalimovTR.Sprint5.Task1.V1.Lib
{
    public class DataService : ISprint5Task1V1
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            double y = Math.Round((3 * Math.Pow(startValue, 4) + 1) / Math.Pow(stopValue, 3), 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
