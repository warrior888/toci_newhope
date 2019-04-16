using System.Collections.Generic;

namespace Toci.AI.Classes
{
    public class TrainedNode : ITrainedNode
    {
        public IEnumerable<IBrain> Brain { get; set; }
    }
}