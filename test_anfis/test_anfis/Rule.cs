using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_anfis
{
    class Rule
    {
        public MembershipFunction mfA;
        public MembershipFunction mfB;
        public TNorm norm;
        public Conclusion conclusion;

        public Rule(MembershipFunction mfA, MembershipFunction mfB, TNorm norm,
                Conclusion conclusion)
        {
            this.mfA = mfA;
            this.mfB = mfB;
            this.norm = norm;
            this.conclusion = conclusion;
        }

        public double conclude(double x, double y)
        {
            return conclusion.compute(x, y);
        }

        public double weight(double x, double y)
        {
            return norm.computeNorm(mfA.compute(x), mfB.compute(y));
        }
    }
}
