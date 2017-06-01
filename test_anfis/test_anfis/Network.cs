using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_anfis
{
    class Network
    {
        private const double NB_a = -1;
        private const double NB_b = -1;
        private const double NB_c = -0.6;

        private const double NM_a = -1;
        private const double NM_b = -0.6;
        private const double NM_c = 0;

        private const double NS_a = -1;
        private const double NS_b = -0.4;
        private const double NS_c = 0;

        private const double ZO_a = -0.4;
        private const double ZO_b = 0;
        private const double ZO_c = 0.4;

        private const double PS_a = 0;
        private const double PS_b = 0.4;
        private const double PS_c = 1;

        private const double PM_a = 0;
        private const double PM_b = 0.6;
        private const double PM_c = 1;

        private const double PB_a = 0.6;
        private const double PB_b = 1;
        private const double PB_c = 1;

        private const double gain = 50;

        private Rule[] rules;

        private double η;

        private Random rand;

        public Network(double η, Random rand)
        {

            this.rand = rand;

            this.η = η;

            createRules();

        }

        /**
         * Rule maker.
         * @param rulesCount
         */
        private void createRules()
        {
            double[,] mf_array = { { NB_a, NB_b, NB_c }, { NM_a, NM_b, NM_c }, { NS_a, NS_b, NS_c }, { ZO_a, ZO_b, ZO_c }, { PS_a, PS_b, PS_c }, { PM_a, PM_b, PM_c }, { PB_a, PB_b, PB_c } };

            for (int i = 0; i < mf_array.Length / 3; i++)
                for (int j = 0; j < 3; j++)
                    mf_array[i, j] *= gain;
            rules = new Rule[mf_array.Length / 3 * mf_array.Length / 3];
            for (int i = 0; i < mf_array.Length / 3; i++)
                for (int j = 0; j < mf_array.Length / 3; j++)
                    rules[i * mf_array.Length / 3 + j] = new Rule(new MembershipFunction(mf_array[i, 0], mf_array[i, 1], mf_array[i, 2]), new MembershipFunction(mf_array[j, 0], mf_array[j, 1], mf_array[j, 2]), new TNorm(), new Conclusion(rand));
        }

        /**
         * Computing Network Output For Input.
         * @param x
         * @param y
         */
        private double compute(double x, double y)
        {

            double[] w = new double[rules.Count()];
            double weightSum = 0;

            //LAYER 1 AND LAYER 2
            for (int i = 0; i < rules.Count(); i++)
            {
                w[i] = rules[i].weight(x, y);
                weightSum += w[i];
            }

            //LAYER 3, 4 AND LAYER 5
            double f = 0;
            for (int i = 0; i < rules.Count(); i++)
            {
                f += w[i] * rules[i].conclude(x, y) / weightSum;
            }

            return f;
        }

        /**
         * Offline Network Learning.
         * @param learningDataset
         * @param error
         */
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

                //all the same if up or down
                double sumw = sumWeights(x, y);

                //network value
                double z = compute(x, y);

                double main_derive = η * (value - z) / Math.Pow(sumw, 2);
                double main_derive_consec = η * (value - z) / sumw;

                for (int i = 0; i < rules.Count(); i++)
                {

                    double weight = rules[i].weight(x, y);
                    double μA = rules[i].mfA.compute(x);
                    double μB = rules[i].mfB.compute(y);

                    double σ = Σ(i, x, y);

                    double main_deriv_A = main_derive * σ * μB;
                    double main_deriv_B = main_derive * σ * μA;

                    //antecedent learning
                    rules[i].mfA.α += main_deriv_A * rules[i].mfA.deriv_a(x);
                    rules[i].mfA.β += main_deriv_A * rules[i].mfA.deriv_b(x);
                    rules[i].mfA.c_d += main_deriv_A * rules[i].mfA.deriv_c(x);

                    rules[i].mfB.α += main_deriv_B * rules[i].mfB.deriv_a(y);
                    rules[i].mfB.β += main_deriv_B * rules[i].mfB.deriv_b(y);
                    rules[i].mfB.c_d += main_deriv_B * rules[i].mfB.deriv_c(y);

                    //consequent learning

                    double consec_deriv = main_derive_consec * weight;

                    rules[i].conclusion.π += consec_deriv * x;
                    rules[i].conclusion.ω += consec_deriv * y;
                    rules[i].conclusion.ρ += consec_deriv;

                }

                error += 0.5 * (compute(x, y) - value) * (compute(x, y) - value);

            }

            updateParameters();

            return error;

        }

        /**
         * Updating paramters.
         */
        private void updateParameters()
        {

            for (int i = 0; i < rules.Count(); i++)
            {
                rules[i].mfA.a += rules[i].mfA.α;
                rules[i].mfA.b += rules[i].mfA.β;
                rules[i].mfA.c += rules[i].mfA.c_d;

                rules[i].mfB.a += rules[i].mfB.α;
                rules[i].mfB.b += rules[i].mfB.β;
                rules[i].mfB.c += rules[i].mfB.c_d;

                rules[i].conclusion.p += rules[i].conclusion.π;
                rules[i].conclusion.q += rules[i].conclusion.ω;
                rules[i].conclusion.r += rules[i].conclusion.ρ;
            }
        }

        /**
         * Initialize sum buffers.
         */
        private void initialize()
        {

            for (int i = 0; i < rules.Count(); i++)
            {
                rules[i].conclusion.π = 0;
                rules[i].conclusion.ρ = 0;
                rules[i].conclusion.ω = 0;

                rules[i].mfA.α = 0;
                rules[i].mfA.β = 0;
                rules[i].mfA.c_d = 0;

                rules[i].mfB.α = 0;
                rules[i].mfB.β = 0;
                rules[i].mfB.c_d = 0;
            }

        }

        /**
         * Sum weights of all rules for sample (x,y).
         * @param x
         * @param y
         * @return
         */
        private double sumWeights(double x, double y)
        {

            double sumW = 0;

            for (int i = 0; i < rules.Count(); i++)
            {
                sumW += rules[i].weight(x, y);
            }

            return sumW;
        }

        /**
         * Sum weights of all rules for sample (x,y) 
         * except rule i.
         * @param i
         * @param x
         * @param y
         * @return
         */
        private double Σ(int i, double x, double y)
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

        /**
         * Validation.
         * @param learningDataset
         */
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

        public void writeLearnedParams2File(string filename)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);

            for (int i = 0; i < rules.Count(); i++)
            {
                file.WriteLine(rules[i].mfA.a.ToString() + " " +
                        rules[i].mfA.b.ToString() + " " +
                        rules[i].mfA.c.ToString() + " " +
                        rules[i].mfB.a.ToString() + " " +
                        rules[i].mfB.b.ToString() + " " +
                        rules[i].mfB.c.ToString() + " " +
                        rules[i].conclusion.p.ToString() + " " +
                        rules[i].conclusion.q.ToString() + " " +
                        rules[i].conclusion.r.ToString());
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

        public void writeEpochErrorForEta2File(double η, List<Pair> learningDataset, int epoch)
        {

            double oldη = this.η;

            this.η = η;
            double iterError = 0;

            System.IO.StreamWriter file = new System.IO.StreamWriter("XepochEtaError.txt");

            for (int e = 0; e < epoch; e++)
            {

                iterError = learnNetwork(learningDataset);

                file.WriteLine(e + " " + iterError);

                Console.WriteLine("Error: " + iterError + " Epoch: " + e);
            }

            file.Close();

            this.η = oldη;

        }

        public void learnNetworkRules(List<Pair> learningDataset, int startRuleNum, int endRuleNum, int epochPerRule)
        {

            double smallestError = 0;
            int bestRuleCount = 0;

            for (int r = startRuleNum; r <= endRuleNum; r++)
            {

                createRules();
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
