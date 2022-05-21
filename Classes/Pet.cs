using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    public class Pet : Animal
    {
        private String _name;
        public String GetName() { return _name; }
        public void SetName(String newName) { _name = newName; }

        public override void SetWeight(double newWeight)
        {
            Weight = newWeight;
            decimal roundedWeight = Decimal.Round((decimal)Weight, 2);
            Weight = (double)roundedWeight;
            if (Weight < MinimumWeight)
            {
                bool isPet = HasMethod.MethodChecker(this, "getName");
                if (isPet) CheckHealth(this.GetName());
                else CheckHealth(null);
            }
        }
    }
}
