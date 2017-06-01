using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_anfis
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------constants-------------------
            //0.002 INITIAL MU
            //0.006 BIG MU
            //0.00002 SMALL MU
            double η = 0.00016;

            int minDomain = -45;
            int maxDomain = 45;

            Function_P function_p = new Function_P();
            Function_I function_i = new Function_I();
            Function_D function_d = new Function_D();

            Dataset dataset_p = new Dataset(minDomain, maxDomain, function_p);
            Dataset dataset_i = new Dataset(minDomain, maxDomain, function_i);
            Dataset dataset_d = new Dataset(minDomain, maxDomain, function_d);
            //------------------end constants-----------------

            //--------------fuzzy-neural network--------------
            //OnlineGradientDescent / OfflineGradientDescent
            Network network_p = new Network(η, new Random());
            Network network_i = new Network(η, new Random());
            Network network_d = new Network(η, new Random());

            //----------------network learning----------------
            //network.learnNetworkEpoch(dataset.getTrainingSet(), 15000);
            network_p.learnNetworkError(dataset_p.getTrainingSet(), 0.1);
            network_p.writeRelativeError2File(dataset_p.getValidationSet(new Random(), 100000));
            network_p.writeLearnedParams2File("P.txt");

            /*network_i.learnNetworkError(dataset_i.getTrainingSet(), 0.1);
            network_i.writeRelativeError2File(dataset_i.getValidationSet(new Random(), 100000));
            network_i.writeLearnedParams2File("I.txt");*/

            /*network_d.learnNetworkError(dataset_d.getTrainingSet(), 0.1);
            network_d.writeRelativeError2File(dataset_d.getValidationSet(new Random(), 100000));
            network_d.writeLearnedParams2File("D.txt");*/
            //network.learnNetworkRules(dataset.getTrainingSet(), 10, 15, 20000);
            //network.writeEpochError2File(dataset.getTrainingSet(), 15000);

            //---------------network validation---------------
            //network.validateLearned(dataset.getTrainingSet());

        }
    }
}