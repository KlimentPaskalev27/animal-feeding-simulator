using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    public interface ILivable
    {
        void SetHealth(int newHealth);
        int GetHealth();
        bool IsStillAlive();
    }
}
