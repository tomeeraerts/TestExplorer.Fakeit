using System;
using FakeItEasy;
using MainPackage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Package.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = A.Fake<IMainInterface>();
        }
    }
}
