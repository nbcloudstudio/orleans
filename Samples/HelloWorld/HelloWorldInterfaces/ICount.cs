using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;

namespace HelloWorldInterfaces
{
    /// <summary>
    /// Orleans grain communication interface IHello
    /// </summary>
    public interface ICount : Orleans.IGrainWithIntegerKey
    {
        Task<int> Plusplus();
    }
}
