using Tyuiu.MasalimovTR.Sprint5.Task0.V25.Lib;
using System.IO;

namespace Tyuiu.MasalimovTR.Sprint5.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        string path = @"C:\Users\Timur\source\repos\Tyuiu.MasalimovTR.Sprint5\Tyuiu.MasalimovTR.Sprint5.Task0.V25\bin\Debug\net8.0\OutPutFileTask0.txt";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExist = fileInfo.Exists;
        Assert.IsTrue(fileExist);
        }
    }
}