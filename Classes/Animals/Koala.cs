using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding.Classes.Animals
{
    class Koala
    {
        private Animal _koala = new Animal();

        public Koala(int hp, double weight, Foods[] edibleFoods, String sound)
        {
            //koala = new Animal();
            this.SetHealth(hp);
            this.SetWeight(weight);
            foreach (var food in edibleFoods)
            {
                this.SetEdibleFoods(food);
            }
            this.SetSound(sound);
        }

        public bool IsStillAlive() { return _koala.IsStillAlive(); }
        public void SetHealth(int newHealth) { _koala.SetHealth(newHealth); }
        public int GetHealth() { return _koala.GetHealth(); }
        public void SetSound(String newSound) { _koala.SetSound(newSound); }
        public String GetSound() { return _koala.GetSound(); }
        public List<Foods> GetEdibleFoods() { return _koala.GetEdibleFoods(); }
        public void SetEdibleFoods(Foods newEdibleFood) { _koala.SetEdibleFoods(newEdibleFood); }
        public double GetWeight() { return _koala.GetWeight(); }

        public void SetWeight(double newWeight)
        {
            _koala.SetWeight(newWeight);
        }

        public void Eat(Foods food, string? name)
        {
            _koala.Eat(food, null);
        }

        public void CheckHealth(string? name)
        {
            _koala.CheckHealth(null);
        }
    }
}
