namespace Tyuiu.MasalimovTR.Sprint5.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Timur\source\repos\Tyuiu.MasalimovTR.Sprint5\Tyuiu.MasalimovTR.Sprint5.Task1.V1\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.IsTrue(fileExist);
        }
    }
}