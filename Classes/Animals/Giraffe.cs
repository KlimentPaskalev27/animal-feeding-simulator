using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    public class Giraffe : Animal
    {
        private static Foods[] _giraffeFoods = { Foods.APPLES, Foods.SPINACH, Foods.CARROTS, Foods.CEREAL };

        private static Giraffe _instance = new Giraffe(5, 105.6, _giraffeFoods);

        private Giraffe(int hp, double weight, Foods[] edibleFoods)
        {
            SetHealth(hp);
            SetWeight(weight);
            MinimumWeight = 100;
            CheckHealth(null);

            foreach (var food in edibleFoods)
            {
                this.SetEdibleFoods(food);
            }
        }

        public static Giraffe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Giraffe(5, 105.6, _giraffeFoods);
                }
                return _instance;
            }
        }
    }
}
