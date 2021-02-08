﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest.Project
{
    [TestClass]
    public class ByAlphabeticalOrder
    {
        public static bool Test1Called;
        public static bool Test2Called;
        public static bool Test3Called;

        [TestMethod]
        public void Test2()
        {
            Test1Called = true;

            Assert.IsTrue(Test1Called);
            Assert.IsFalse(Test3Called);
        }

        [TestMethod]
        public void Test1()
        {
            //Test2Called = true;

            Assert.IsFalse(Test2Called);
            Assert.IsFalse(Test3Called);
        }

        [TestMethod]
        public void Test3()
        {
            Test1Called = true;
            Test2Called = true;

            Assert.IsTrue(Test1Called);
            Assert.IsTrue(Test2Called);
        }
    }
}
