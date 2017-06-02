using System;
using System.Collections.Generic;
using System.Linq;
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

        private double eta;

        private Random rand;

        public Network(double eta, Random rand)
        {
            this.rand = rand;
            this.eta = eta;
            createRules();
        }

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

        private double compute(double x, double y)
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

                double main_derive = eta * (value - z) / Math.Pow(sumw, 2);
                double main_derive_consec = eta * (value - z) / sumw;

                Parallel.For(0, rules.Count(), (i, state) =>
                {

                    double weight = rules[i].weight(x, y);
                    double mu_A = rules[i].mfA.compute(x);
                    double mu_B = rules[i].mfB.compute(y);

                    double sigma = sigma_sum(i, x, y);

                    double main_deriv_A = main_derive * sigma * mu_B;
                    double main_deriv_B = main_derive * sigma * mu_A;


                    rules[i].mfA.a_d += main_deriv_A * rules[i].mfA.deriv_a(x);
                    rules[i].mfA.b_d += main_deriv_A * rules[i].mfA.deriv_b(x);
                    rules[i].mfA.c_d += main_deriv_A * rules[i].mfA.deriv_c(x);

                    rules[i].mfB.a_d += main_deriv_B * rules[i].mfB.deriv_a(y);
                    rules[i].mfB.b_d += main_deriv_B * rules[i].mfB.deriv_b(y);
                    rules[i].mfB.c_d += main_deriv_B * rules[i].mfB.deriv_c(y);

                    double consec_deriv = main_derive_consec * weight;

                    rules[i].conclusion.p_d += consec_deriv * x;
                    rules[i].conclusion.q_d += consec_deriv * y;
                    rules[i].conclusion.r_d += consec_deriv;

                });

                error += 0.5 * (compute(x, y) - value) * (compute(x, y) - value);

            }

            updateParameters();

            return error;
        }

        private void updateParameters()
        {
            for (int i = 0; i < rules.Count(); i++)
            {
                rules[i].mfA.a += rules[i].mfA.a_d;
                rules[i].mfA.b += rules[i].mfA.b_d;
                rules[i].mfA.c += rules[i].mfA.c_d;

                rules[i].mfB.a += rules[i].mfB.a_d;
                rules[i].mfB.b += rules[i].mfB.b_d;
                rules[i].mfB.c += rules[i].mfB.c_d;

                rules[i].conclusion.p += rules[i].conclusion.p_d;
                rules[i].conclusion.q += rules[i].conclusion.q_d;
                rules[i].conclusion.r += rules[i].conclusion.r_d;
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
                rules[i].mfA.c_d = 0;

                rules[i].mfB.a_d = 0;
                rules[i].mfB.b_d = 0;
                rules[i].mfB.c_d = 0;
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
    }
}
