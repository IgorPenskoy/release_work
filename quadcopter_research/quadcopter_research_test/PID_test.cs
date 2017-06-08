using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using quadcopter_research;

namespace quadcopter_research_test
{
    [TestClass]
    public class PID_test
    {
        [TestMethod]
        public void TestGetEffect_1()
        {
            PID pid = new PID(0.05, 10, 50, 1, 2, 3);
            Assert.AreEqual(pid.get_effect(0, 0), 0);
        }

        [TestMethod]
        public void TestGetEffect_2()
        {
            PID pid = new PID(0.05, 10, 50, 0.5, 0, 0);
            Assert.AreEqual(pid.get_effect(10, 0), -5);
        }

        [TestMethod]
        public void TestGetEffect_3()
        {
            PID pid = new PID(0.05, 10, 50, 1, 2, 3);
            pid.set_sumError(100);
            Assert.AreEqual(pid.get_effect(1, 0), -10);
        }

        [TestMethod]
        public void TestGetEffect_4()
        {
            PID pid = new PID(0.05, 10, 50, 1, 2, 3);
            Assert.AreEqual(pid.get_effect(10, 0), -10);
        }
    }
}
