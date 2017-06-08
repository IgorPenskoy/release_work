using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using quadcopter_research;

namespace quadcopter_research_test
{
    [TestClass]
    public class TestMisc
    {
        [TestMethod]
        public void TestRuleConclude()
        {
            Rule r = new Rule("1 2 3 4 5 6 1 2 3");
            Assert.AreEqual(r.conclude(1, 2), 8);
        }

        [TestMethod]
        public void TestRuleWeight()
        {
            Rule r = new Rule("1 2 3 4 5 6 1 2 3");
            Assert.AreEqual(r.weight(1.5, 4.5), 0.25);
        }

        [TestMethod]
        public void TestTNormCompute()
        {
            TNorm tn = new TNorm();
            Assert.AreEqual(tn.computeNorm(0.4, 0.5), 0.2);
        }

        [TestMethod]
        public void TestMembershipFunctionCompute_1()
        {
            MembershipFunction mf = new MembershipFunction(1, 2, 3);
            Assert.AreEqual(mf.compute(1), 0);
        }

        [TestMethod]
        public void TestMembershipFunctionCompute_2()
        {
            MembershipFunction mf = new MembershipFunction(1, 2, 3);
            Assert.AreEqual(mf.compute(1.5), 0.5);
        }

        [TestMethod]
        public void TestMembershipFunctionCompute_3()
        {
            MembershipFunction mf = new MembershipFunction(1, 2, 3);
            Assert.AreEqual(mf.compute(2), 1);
        }

        [TestMethod]
        public void TestMembershipFunctionCompute_4()
        {
            MembershipFunction mf = new MembershipFunction(1, 2, 3);
            Assert.AreEqual(mf.compute(2.5), 0.5);
        }

        [TestMethod]
        public void TestMembershipFunctionDerive_a_1()
        {
            MembershipFunction mf = new MembershipFunction(1, 2, 3);
            Assert.AreEqual(mf.deriv_a(1), 0);
        }

        [TestMethod]
        public void TestMembershipFunctionDerive_a_2()
        {
            MembershipFunction mf = new MembershipFunction(1, 2, 3);
            Assert.AreEqual(mf.deriv_a(1.2), -0.8);
        }

        [TestMethod]
        public void TestMembershipFunctionDerive_b_1()
        {
            MembershipFunction mf = new MembershipFunction(1, 2, 3);
            Assert.AreEqual(mf.deriv_b(1), 0);
        }

        [TestMethod]
        public void TestMembershipFunctionDerive_b_2()
        {
            MembershipFunction mf = new MembershipFunction(1, 2, 3);
            Assert.AreEqual(mf.deriv_b(1.5), -0.5);
        }

        [TestMethod]
        public void TestMembershipFunctionDerive_b_3()
        {
            MembershipFunction mf = new MembershipFunction(1, 2, 3);
            Assert.AreEqual(mf.deriv_b(2.5), 0.5);
        }

        [TestMethod]
        public void TestMembershipFunctionDerive_c_1()
        {
            MembershipFunction mf = new MembershipFunction(1, 2, 3);
            Assert.AreEqual(mf.deriv_c(1), 0);
        }

        [TestMethod]
        public void TestMembershipFunctionDerive_c_2()
        {
            MembershipFunction mf = new MembershipFunction(1, 2, 3);
            Assert.AreEqual(mf.deriv_c(2.5), 0.5);
        }

        [TestMethod]
        public void TestConclusionCompute()
        {
            Conclusion cn = new Conclusion(1, 2, 3);
            Assert.AreEqual(cn.compute(4, 5), 17);
        }
    }
}
