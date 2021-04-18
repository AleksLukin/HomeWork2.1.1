using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HomeWork211.Test

{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void CheckNumber_Value_Test()
        {
            int number = 5;
            int expected = 0;

            int actual = Program.CheckNumber(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
