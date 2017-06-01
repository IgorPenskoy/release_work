using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_anfis
{
    class Dataset
    {
        private int min;
        private int max;
        private Function function;

        private List<Pair> trainingSet;

        public Dataset(int min, int max, Function function)
        {

            this.min = min;
            this.max = max;
            this.function = function;

            createLearningDataset();
        }

        private void createLearningDataset()
        {

            trainingSet = new List<Pair>();

            for (int i = min; i <= max; i += 5)
            {
                for (int j = min; j <= max; j += 5)
                {
                    trainingSet.Add(new Pair(i, j, function.compute(i, j, max)));
                }
            }
        }

        public List<Pair> getValidationSet(Random rand, int setSize)
        {

            List<Pair> validationSet = new List<Pair>();

            for (int i = 0; i < setSize; i++)
            {
                double x = (max - min) * rand.NextDouble() + min;
                double y = (max - min) * rand.NextDouble() + min;
                validationSet.Add(new Pair(x, y, function.compute(x, y, max)));
            }

            return validationSet;
        }

        public List<Pair> getTrainingSet()
        {
            return trainingSet;
        }
    }
}
