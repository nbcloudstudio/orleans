using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;

namespace HelloWorldGrains
{
    /// <summary>
    /// Orleans grain implementation class HelloGrain.
    /// </summary>
    public class CountGrain : Orleans.Grain, HelloWorldInterfaces.ICount
    {
        private int counter = 0;
        Task<int> HelloWorldInterfaces.ICount.Plusplus()
        {
            counter++;
            return Task.FromResult(counter);
        }
    }
}
