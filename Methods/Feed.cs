using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    public class Feed
    {
        private static void RandFood(Animal animal, Foods randomFood, string? name)
        {
            animal.Eat(randomFood, name);
            animal.SetWeight( animal.GetWeight() + WeightCalc.CalculateWeightGain(randomFood, animal, MenuCreator.GetMenu()) );
        }

        public static void AllAnimals(Animal[] animals)
        {
            Random rand = new Random();

            foreach (var animal in animals)
            {
                while (animal.IsStillAlive())
                {
                    Array values = Enum.GetValues(typeof(Foods));
                    Foods randomFood = (Foods)values.GetValue(rand.Next(values.Length));

                    if (animal is Pet)
                    {
                        Pet ispet = (Pet)animal;
                        RandFood(animal, randomFood, ispet.GetName());
                    }
                    else RandFood(animal, randomFood, null);
                }
            }
        }
    }
}
