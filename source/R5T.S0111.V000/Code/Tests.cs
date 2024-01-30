using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace R5T.S0111.V000
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void AreEqual_ForIntegers()
        {
            var a = 1;
            var b = 2;

            Assert.AreEqual(a, b);
        }
    }
}
