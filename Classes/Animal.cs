using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    public class Animal : Creature, ILivable
    {
        private int _health;
        public int TimesFed;
        private List<Foods> _edibleFoods = new List<Foods>();

        public bool IsStillAlive() { return IsAlive; }
        public void SetHealth(int newHealth) { _health = newHealth; }
        public int GetHealth() { return _health; }
        public override void SetSound(String newSound) { Sound = newSound; }
        public override String GetSound() { return Sound; }
        public List<Foods> GetEdibleFoods() { return _edibleFoods; }
        public void SetEdibleFoods(Foods newEdibleFood) { _edibleFoods.Add(newEdibleFood); }
        public override double GetWeight() { return Weight; }

        public override void SetWeight(double newWeight)
        {
            Weight = newWeight;
            decimal roundedWeight = Decimal.Round((decimal)Weight, 2);
            Weight = (double)roundedWeight;
            if (Weight < MinimumWeight)
            {
                CheckHealth(null);
            }
        }

        public override void Eat(Foods food, string? name)
        {
            if (name == null)
            {
                if (IsAlive && IsStillAlive())
                {
                    TimesFed++;
                    if (_edibleFoods.Contains(food))
                    {
                        _health++;
                        Console.WriteLine($"The {this.GetType().Name} eats the {food} with joy and now has {_health} health points and weighs {Weight}kg.");
                    }
                    else
                    {
                        _health--;
                        Console.WriteLine($"The {this.GetType().Name} eats the {food} with disgust and now has {_health} health points and weighs {Weight}kg.");
                        CheckHealth(null);
                    }
                }
            }
            else
            {
                if (IsAlive && IsStillAlive())
                {
                    TimesFed++;
                    if (GetEdibleFoods().Contains(food))
                    {
                        _health++;
                        Console.WriteLine($"{this.GetSound()} - Says {name} the {this.GetType().Name} with joy as it eats the {food} -> now has {_health} health points and weighs {Weight}kg.");
                    }
                    else
                    {
                        _health--;
                        Console.WriteLine($"{this.GetSound()} - Says {name} the {this.GetType().Name} with disgust as it eats the {food} -> now has {_health} health points and weighs {Weight}kg.");
                        bool isPet = HasMethod.MethodChecker(this, "getName");
                        if (isPet) CheckHealth(name);
                        else CheckHealth(null);
                    }
                }
            }
        }

        public override void CheckHealth(string? name)
        {
            if ( name == null)
            {
                if (!AnnouncedDead)
                {
                    if (_health == 0)
                    {
                        IsAlive = false;
                        Console.WriteLine($"The {this.GetType().Name} now has 0 health and is dead. The {this.GetType().Name} was fed {TimesFed} times.");
                        AnnouncedDead = true;
                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                    }
                    else if (GetWeight() <= MinimumWeight)
                    {
                        IsAlive = false;
                        Console.WriteLine($"The {this.GetType().Name} is dead because of malnourishment and its WEIGHT dropped under the minimum weight at {Weight}. The {this.GetType().Name} was fed {TimesFed} times.");
                        AnnouncedDead = true;
                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                    }
                    else
                    {
                        IsAlive = true;
                        AnnouncedDead = false;
                    }
                }
            } else
            {
                if (!AnnouncedDead)
                {
                    if (_health == 0)
                    {
                        IsAlive = false;
                        Console.WriteLine($"{name} the {this.GetType().Name} now has 0 health and is dead. {name} was fed {TimesFed} times.");
                        AnnouncedDead = true;
                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                    }
                    else if (GetWeight() <= MinimumWeight)
                    {
                        IsAlive = false;
                        Console.WriteLine($"{name} the {this.GetType().Name} is dead because of malnourishment and its WEIGHT dropped under the minimum weight at {Weight}. {name} was fed {TimesFed} times.");
                        AnnouncedDead = true;
                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                    }
                    else
                    {
                        IsAlive = true;
                        AnnouncedDead = false;
                    }
                }
            }
        }
    }
}
