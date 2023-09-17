﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint0.Task5.V0.Lib;

namespace Tyuiu.MezentsevSE.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));

        }

        [TestMethod]

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        [TestMethod]

        public void CheckedMultipicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));

        }
        [TestMethod]

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));


        }
    }
}