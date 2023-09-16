using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MezentsevSE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Семён";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет...,Семён", res);
        }
    }
}
