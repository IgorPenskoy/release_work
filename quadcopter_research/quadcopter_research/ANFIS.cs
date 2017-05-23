using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class ANFIS
    {
        private const int rules_count_const = 16;
        private const double mu_const = 0.002;

        private Rule[] rules;

        private double mu;

        private Random rand;

        public ANFIS(Random rand, int rulesCount = rules_count_const, double mu = mu_const)
        {

            this.rand = rand;

            this.mu = mu;

            createRules(rulesCount);

        }

        private void createRules(int rulesCount)
        {

            this.rules = new Rule[rulesCount];

            for (int i = 0; i < rules.Count(); i++)
            {

                rules[i] = new Rule(
                        new MembershipFunction(rand),
                        new MembershipFunction(rand),
                        new TNorm(),
                        new Conclusion(rand));
            }
        }

        public double compute(double x, double y)
        {

            double[] w = new double[rules.Count()];
            double weightSum = 0;

            for (int i = 0; i < rules.Count(); i++)
            {
                w[i] = rules[i].weight(x, y);
                weightSum += w[i];
            }

            double f = 0;
            for (int i = 0; i < rules.Count(); i++)
            {
                f += w[i] * rules[i].conclude(x, y) / weightSum;
            }

            return f;
        }

        private double learnNetwork(List<Pair> learningDataset)
        {

            double error = 0;



            learningDataset = learningDataset.OrderBy(item => rand.Next()).ToList();

            initialize();

            for (int j = 0; j < learningDataset.Count(); j++)
            {


                double x = learningDataset[j].x;
                double y = learningDataset[j].y;
                double value = learningDataset[j].value;

                double sumw = sumWeights(x, y);

                double z = compute(x, y);

                for (int i = 0; i < rules.Count(); i++)
                {

                    double weight = rules[i].weight(x, y);
                    double mu_A = rules[i].mfA.compute(x);
                    double mu_B = rules[i].mfB.compute(y);

                    double o = value;

                    double a1 = rules[i].mfA.a;
                    double b1 = rules[i].mfA.b;
                    double a2 = rules[i].mfB.a;
                    double b2 = rules[i].mfB.b;

                    double sigma = sigma_sum(i, x, y);

                    rules[i].mfA.a_d +=
                            mu * (o - z) *
                            sigma / Math.Pow(sumw, 2) *
                            (mu_B * mu_B) / Math.Pow(mu_A + mu_B - mu_A * mu_B, 2) *
                            b1 * mu_A * (1 - mu_A);

                    rules[i].mfA.b_d +=
                            mu * (o - z) *
                            sigma / Math.Pow(sumw, 2) *
                            (mu_B * mu_B) / Math.Pow(mu_A + mu_B - mu_A * mu_B, 2) *
                            (-(x - a1)) * mu_A * (1 - mu_A);

                    rules[i].mfB.a_d +=
                            mu * (o - z) *
                            sigma / Math.Pow(sumw, 2) *
                            (mu_A * mu_A) / Math.Pow(mu_A + mu_B - mu_A * mu_B, 2) *
                            b2 * mu_B * (1 - mu_B);

                    rules[i].mfB.b_d +=
                            mu * (o - z) *
                            sigma / Math.Pow(sumw, 2) *
                            (mu_A * mu_A) / Math.Pow(mu_A + mu_B - mu_A * mu_B, 2) *
                            (-(y - a2)) * mu_B * (1 - mu_B);

                    rules[i].conclusion.p_d += mu * (o - z) * weight / sumw * x;
                    rules[i].conclusion.q_d += mu * (o - z) * weight / sumw * y;
                    rules[i].conclusion.r_d += mu * (o - z) * weight / sumw;

                }

                error += 0.5 * (compute(x, y) - value) * (compute(x, y) - value);

            }

            updateParameters();

            return error;
        }

        private void updateParameters()
        {

            for (int i = 0; i < rules.Count(); i++)
            {
                rules[i].mfA.a = rules[i].mfA.a + rules[i].mfA.a_d;
                rules[i].mfA.b = rules[i].mfA.b + rules[i].mfA.b_d;

                rules[i].mfB.a = rules[i].mfB.a + rules[i].mfB.a_d;
                rules[i].mfB.b = rules[i].mfB.b + rules[i].mfB.b_d;

                rules[i].conclusion.p = rules[i].conclusion.p + rules[i].conclusion.p_d;
                rules[i].conclusion.q = rules[i].conclusion.q + rules[i].conclusion.q_d;
                rules[i].conclusion.r = rules[i].conclusion.r + rules[i].conclusion.r_d;
            }

        }

        private void initialize()
        {

            for (int i = 0; i < rules.Count(); i++)
            {
                rules[i].conclusion.p_d = 0;
                rules[i].conclusion.r_d = 0;
                rules[i].conclusion.q_d = 0;

                rules[i].mfA.a_d = 0;
                rules[i].mfA.b_d = 0;

                rules[i].mfB.a_d = 0;
                rules[i].mfB.b_d = 0;
            }

        }

        private double sumWeights(double x, double y)
        {

            double sumW = 0;

            for (int i = 0; i < rules.Count(); i++)
            {
                sumW += rules[i].weight(x, y);
            }

            return sumW;
        }

        private double sigma_sum(int i, double x, double y)
        {
            double sum = 0;

            double zi = rules[i].conclusion.compute(x, y);

            for (int j = 0; j < rules.Count(); j++)
            {
                if (j != i)
                {
                    sum += rules[j].weight(x, y) * (zi - rules[j].conclusion.compute(x, y));
                }
            }
            return sum;
        }

        public void validateLearned(List<Pair> learningDataset)
        {

            for (int i = 0; i < learningDataset.Count(); i++)
            {
                double x = learningDataset[i].x;
                double y = learningDataset[i].y;
                double value = learningDataset[i].value;

                double f = compute(x, y);

                Console.WriteLine("Learned: " + f + " Real: " + value + " Error: " + Math.Abs(f - value));
            }

        }

        public void learnNetworkError(List<Pair> learningDataset, double error)
        {

            double iterError = 0;

            int epoch = 0;

            do
            {

                iterError = learnNetwork(learningDataset);

                epoch++;

                Console.WriteLine("Error: " + iterError + " More: " + (iterError - error) + " Epoch: " + epoch);

            } while (iterError > error);

        }

        public void learnNetworkEpoch(List<Pair> learningDataset, int epoch)
        {

            double iterError = 0;

            for (int e = 0; e < epoch; e++)
            {

                iterError = learnNetwork(learningDataset);

                Console.WriteLine("Error: " + iterError + " Epoch: " + e);

            }

        }

        public void writeLearnedParams2File()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("learnedParams.txt");

            for (int i = 0; i < rules.Count(); i++)
            {
                file.WriteLine(rules[i].mfA.a + " " +
                        rules[i].mfA.b + " " +
                        rules[i].mfB.a + " " +
                        rules[i].mfB.b + " " +
                        rules[i].conclusion.p + " " +
                        rules[i].conclusion.q + " " +
                        rules[i].conclusion.r);
            }

            file.Close();
        }

        public void writeRelativeError2File(List<Pair> learningDataset)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("relError.txt");

            for (int i = 0; i < learningDataset.Count(); i++)
            {
                double yk = learningDataset[i].value;
                double ok = compute(learningDataset[i].x, learningDataset[i].y);

                double error = ok - yk;

                file.WriteLine(learningDataset[i].x + " " + learningDataset[i].y + " " + error);

                Console.WriteLine("X: " + learningDataset[i].x + " Y: " + learningDataset[i].y + " ERROR: " + error);

            }

            file.Close();
        }

        public void writeEpochError2File(List<Pair> learningDataset, int epoch)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("offline_epochError.txt");

            double iterError = 0;
            for (int e = 0; e < epoch; e++)
            {

                iterError = learnNetwork(learningDataset);

                file.WriteLine(e + " " + iterError);

                Console.WriteLine("Error: " + iterError + " Epoch: " + e);
            }

            file.Close();
        }

        public void writeEpochErrorForEta2File(double mu, List<Pair> learningDataset, int epoch)
        {

            double old_mu = this.mu;

            this.mu = mu;
            double iterError = 0;

            System.IO.StreamWriter file = new System.IO.StreamWriter("XepochEtaError.txt");

            for (int e = 0; e < epoch; e++)
            {

                iterError = learnNetwork(learningDataset);

                file.WriteLine(e + " " + iterError);

                Console.WriteLine("Error: " + iterError + " Epoch: " + e);
            }

            file.Close();

            this.mu = old_mu;

        }

        public void learnNetworkRules(List<Pair> learningDataset, int startRuleNum, int endRuleNum, int epochPerRule)
        {

            double smallestError = 0;
            int bestRuleCount = 0;

            for (int r = startRuleNum; r <= endRuleNum; r++)
            {

                createRules(r);
                double iterError = 0;

                Console.WriteLine("==========");

                for (int e = 0; e < epochPerRule; e++)
                {

                    iterError = learnNetwork(learningDataset);

                    Console.WriteLine("Rules: " + r + " Epoch: " + e + " Error: " + iterError);

                }

                if (r == startRuleNum || iterError < smallestError)
                {
                    bestRuleCount = r;
                    smallestError = iterError;
                }

            }
            Console.WriteLine("Best Rule Count: " + bestRuleCount + " Error: " + smallestError);
        }
    }
}