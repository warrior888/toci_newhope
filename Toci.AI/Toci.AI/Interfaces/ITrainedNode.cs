using System.Collections;
using System.Collections.Generic;

namespace Toci.AI
{
    public interface ITrainedNode
    {
        IEnumerable<IBrain> Brain { get; set; }
    }
}