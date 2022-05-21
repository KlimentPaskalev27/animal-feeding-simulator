using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    public class Cat : Pet
    {
        public void Claw()
        {
            Console.WriteLine("Clawed at your arm!");
        }

        public Cat(String name, int hp, double weight, Foods[] edibleFoods, String sound)
        {
            SetName(name);
            SetHealth(hp);
            SetWeight(weight);
            SetSound(sound);
            CheckHealth(name);
            MinimumWeight = 1.5;

            foreach (var food in edibleFoods)
            {
                this.SetEdibleFoods(food);
            }
        }
    }
}
