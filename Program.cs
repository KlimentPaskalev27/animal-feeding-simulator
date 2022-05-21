using AnimalFeeding.Classes.Animals;
using System;

namespace AnimalFeeding
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuCreator.CreateMenu();

            Foods[] dogFoods = { Foods.MEAT, Foods.BONES, Foods.CARTILAGE, Foods.PIZZA };
            Foods[] catFoods = { Foods.TUNA, Foods.MEAT, Foods.PIZZA };

            // How to edit constructor if you want to play around
            Dog wolfy = new Dog("Wolfy", // give it a name
                                    7, // how many life points it can have
                                    6.1, // how much does it weigh
                                    dogFoods, // indices of the Foods enum to tell it which foods are edible
                                    "WOOF!"); // what sound does this animal make?

            Animal barko = new Dog("Barko", 8, 5.8, dogFoods, "Bark bark!");
            Cat pepi = new Cat("Pepi", 5, 3.5, catFoods, "Meow");
            Giraffe giraf = Giraffe.Instance; //Singleton constructor design pattern

            Animal[] animals = new Animal[4];
            animals[0] = wolfy;
            animals[1] = barko;
            animals[2] = pepi;
            animals[3] = giraf;

            Feed.AllAnimals(animals);
            SurvivedLongest.LivedLongest(animals);
        }
    }
}
