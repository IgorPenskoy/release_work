namespace quadcopter_research
{
    public class Rule
    {
        public MembershipFunction mfA;
        public MembershipFunction mfB;
        public TNorm norm;
        public Conclusion conclusion;

        public Rule(MembershipFunction mfA, MembershipFunction mfB, TNorm norm, Conclusion conclusion)
        {
            this.mfA = mfA;
            this.mfB = mfB;
            this.norm = norm;
            this.conclusion = conclusion;
        }

        public Rule(string parameters)
        {
            parameters = parameters.Trim();

            string[] pr = parameters.Split(' ');

            mfA = new MembershipFunction(double.Parse(pr[0]), double.Parse(pr[1]), double.Parse(pr[2]));
            mfB = new MembershipFunction(double.Parse(pr[3]), double.Parse(pr[4]), double.Parse(pr[5]));

            conclusion = new Conclusion(double.Parse(pr[6]), 
                                        double.Parse(pr[7]), 
                                        double.Parse(pr[8]));

            norm = new TNorm();
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
