using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    public class SurvivedLongest
    {
        public static void LivedLongest(Animal[] animals)
        {
            Animal livedLongest = animals[0];
            int timesFed = 0;
            foreach (Animal animal in animals)
            {
                if (animal.TimesFed > timesFed)
                {
                    livedLongest = animal;
                    timesFed = animal.TimesFed;
                }
            }

            // check if animal has name
            bool isPet = HasMethod.MethodChecker(livedLongest, "getName");
            if (isPet)
            {
                Pet pet = (Pet)livedLongest;
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.WriteLine($"{pet.GetName()} the {livedLongest.GetType().Name} survived the longest. It ate {timesFed} times.");
                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.WriteLine($"The {livedLongest.GetType().Name} survived the longest. It ate {timesFed} times.");
                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
        }
    }
}
