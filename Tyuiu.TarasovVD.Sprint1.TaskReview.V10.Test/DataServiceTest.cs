using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint1.TaskReview.V10.Lib;

namespace Tyuiu.TarasovVD.Sprint1.TaskReview.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double wait = -13.142;
            double z = ds.Calculate(x);
            Assert.AreEqual(wait, z);
        }
    }
}
