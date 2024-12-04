using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MasalimovTR.Sprint5.Task2.V14.Lib
{
    public class DataService : ISprint5Task2V14
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.txt" });
            string y = "11";
            
            File.WriteAllText(path, y);
            return path;
        }
    }
}
