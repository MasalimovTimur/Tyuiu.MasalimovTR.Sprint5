using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MasalimovTR.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);

            double res = Math.Round(Convert.ToDouble(strx),3);
            return res;
        }
    }
}
