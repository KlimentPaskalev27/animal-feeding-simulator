using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    public class Dog : Pet
    {
        public Dog(String name, int hp, double weight, Foods[] edibleFoods, String sound)
        {
            SetName(name);
            SetHealth(hp);
            SetWeight(weight);
            MinimumWeight = 4;
            SetSound(sound);
            CheckHealth(name);

            foreach (var food in edibleFoods)
            {
                this.SetEdibleFoods(food);
            }
        }
    }
}
