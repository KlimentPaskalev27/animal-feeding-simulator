using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    public abstract class Creature
    {
        protected double MinimumWeight;
        protected double Weight;
        protected String Sound;
        protected bool IsAlive;
        protected bool AnnouncedDead;
        public abstract void SetWeight(double newWeight);
        public abstract double GetWeight();
        public abstract void SetSound(String newSound);
        public abstract String GetSound();
        public abstract void Eat(Foods food, string? name);
        public abstract void CheckHealth(string? name);
    }
}
