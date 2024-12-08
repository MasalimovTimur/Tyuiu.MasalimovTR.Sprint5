using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MasalimovTR.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile(string path)
        {
            

            double res = Math.Round(Math.Sin(-3.57)*(Math.Cos(-3.57)*Math.Pow(- 3.57, 4)),3);
            return res;
        }
    }
}
