using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPoker.Manager.GrainInterface
{
    public interface ITexasPokerManager : Orleans.IGrainWithStringKey
    {
        Task<float> GetPumpingRate();

        Task<float> SetPumpingRate(float rate);
    }
}
