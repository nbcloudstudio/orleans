using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexasPoker.Manager.GrainInterface;

namespace TexasPoker.Manager.Grain
{
    public class TexasPokerManagerGrain : Orleans.Grain, ITexasPokerManager
    {
        float rate = 0.0f;
        Task<float> ITexasPokerManager.GetPumpingRate()
        {
            return Task.FromResult(rate);
        }

        Task<float> ITexasPokerManager.SetPumpingRate(float rate)
        {
            this.rate = rate;
            return Task.FromResult(this.rate);
        }
    }
}
