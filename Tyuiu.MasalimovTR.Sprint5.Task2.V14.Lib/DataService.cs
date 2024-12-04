using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MasalimovTR.Sprint5.Task2.V14.Lib
{
    public class DataService : ISprint5Task2V14
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.txt" });         
            
            File.WriteAllText(path, "0;0;0\n1;1;1\n0;0;1");
            return path;
        }
    }
}
