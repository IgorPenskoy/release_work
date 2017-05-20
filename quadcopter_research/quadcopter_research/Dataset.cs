using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
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

            for (int i = min; i <= max; i++)
            {
                for (int j = min; j <= max; j++)
                {
                    trainingSet.Add(new Pair(i, j, function.compute(i, j)));
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
                validationSet.Add(new Pair(x, y, function.compute(x, y)));
            }

            return validationSet;
        }

        public List<Pair> getTrainingSet()
        {
            return trainingSet;
        }
    }
}
