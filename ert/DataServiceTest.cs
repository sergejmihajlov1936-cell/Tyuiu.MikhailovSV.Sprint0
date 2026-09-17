using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovSV.Sprint0.Task.V0.Lib;

namespace Tyuiu.MikhailovSV.Sprint0.Task.V0.Test
{

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Сергей";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Сергей", res);
        }
    }
}
