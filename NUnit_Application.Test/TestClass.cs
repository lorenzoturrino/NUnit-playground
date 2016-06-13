using System;
using NUnit;
using NUnit_Application;
using NUnit.Framework;

namespace NUnit_Application.Test
{
    [TestFixture]
    public class MathsHelperTest
    {
        [TestCase]
        public void AddTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Add(20, 20);
            Assert.AreEqual(40, result);
        }

        [TestCase]
        public void SubtractTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }

        [TestCase]
        public void ExpoTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Expo(2, 5);
            Assert.AreEqual(32, result);
        }

        [TestCase]
        public void MultiplyTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Multiply(2, 5);
            Assert.AreEqual(10, result);
        }
    }
}
