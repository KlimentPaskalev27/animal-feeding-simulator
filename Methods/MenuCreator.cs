using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    class MenuCreator
    {
        private static Dictionary<Foods, double> _foodToWeight = new Dictionary<Foods, double>();
        public static Dictionary<Foods, double> GetMenu()
        {
            return _foodToWeight;
        }

        public static void CreateMenu()
        {
            // get the value of the last element of the enum so we can use their count
            int foods_count = (int)Enum.GetValues(typeof(Foods)).Cast<Foods>().Last();

            double[] addsToWeight = new double[foods_count];

            // assign random weight gain properties to each Foods type
            Random rand = new Random();

            for (int i = 0; i < foods_count; i++)
            {
                decimal roundedWeight = Decimal.Round((decimal)rand.NextDouble(), 2);
                addsToWeight[i] = (double)roundedWeight;
            }

            for (int i = 0; i < foods_count; i++)
            {
                _foodToWeight.Add((Foods)i, addsToWeight[i]);

            }

            // print out menu with unique weight gain for each Food
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("A random menu was generated where each Food below will result in weight gain for animals.");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            foreach (var item in _foodToWeight)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("If an animal's weight goes below its minimum weight, it will perish from malnourishment.");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }
    }
}
