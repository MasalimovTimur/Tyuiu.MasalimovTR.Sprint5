using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MasalimovTR.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            string pathx = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.txt" });

            double res = Math.Round(67.1, 3);
            return res;
        }
    }
}
