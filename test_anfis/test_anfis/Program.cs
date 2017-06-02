using System;
using System.Threading.Tasks;

namespace test_anfis
{
    class Program
    {
        static void Main(string[] args)
        {

            double eta = 0.00016;

            int minDomain = -45;
            int maxDomain = 45;

            Function_P function_p = new Function_P();
            Function_I function_i = new Function_I();
            Function_D function_d = new Function_D();

            Dataset dataset_p = new Dataset(minDomain, maxDomain, function_p);
            Dataset dataset_i = new Dataset(minDomain, maxDomain, function_i);
            Dataset dataset_d = new Dataset(minDomain, maxDomain, function_d);

            Network network_p = new Network(eta, new Random());
            Network network_i = new Network(eta, new Random());
            Network network_d = new Network(eta, new Random());

            Parallel.Invoke(
            () =>
            {
                network_p.learnNetworkError(dataset_p.getTrainingSet(), 0.1);
                network_p.writeRelativeError2File(dataset_p.getValidationSet(new Random(), 100000));
                network_p.writeLearnedParams2File("P.txt");
            },
            () =>
            {
                network_i.learnNetworkError(dataset_i.getTrainingSet(), 0.1);
                network_i.writeRelativeError2File(dataset_i.getValidationSet(new Random(), 100000));
                network_i.writeLearnedParams2File("I.txt");
            },
            () =>
            {
                network_d.learnNetworkError(dataset_d.getTrainingSet(), 0.1);
                network_d.writeRelativeError2File(dataset_d.getValidationSet(new Random(), 100000));
                network_d.writeLearnedParams2File("D.txt");
            });
        }
    }
}