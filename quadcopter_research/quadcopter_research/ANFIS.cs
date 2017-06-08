using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace quadcopter_research
{
    public class ANFIS
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

        private const double gain = 180;
        private const double mu_const = 0.002;

        private Rule[] rules;

        private double mu;

        private Random rand;

        public ANFIS(Random rand, string file_parameters, double mu = mu_const)
        {

            this.rand = rand;

            this.mu = mu;

            createRules(file_parameters);

        }

        public ANFIS(Random rand, double mu = mu_const)
        {
            this.rand = rand;
            this.mu = mu;
            createRules();
        }

        private void createRules(string file_parameters)
        {
            if (File.Exists(file_parameters))
            {
                string[] lines = File.ReadAllLines(file_parameters);
                rules = new Rule[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    rules[i] = new Rule(lines[i]);
                }
            }
            else
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
            if (weightSum != 0)
                for (int i = 0; i < rules.Count(); i++)
                {
                    f += w[i] * rules[i].conclude(x, y) / weightSum;
                }

            return f;
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
    }
}