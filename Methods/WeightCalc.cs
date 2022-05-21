using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    public class WeightCalc
    {
        public static double CalculateWeightGain(Foods food, Animal animal, Dictionary<Foods, double> foodToWeight)
        {
            double weightGain = 0;
            double calories = foodToWeight.FirstOrDefault(x => x.Key == food).Value;

            if (animal.GetEdibleFoods().Contains(food))
            {
                weightGain += calories;
            }
            else
            {
                weightGain -= calories;
            }
            return weightGain;
        }
    }
}
