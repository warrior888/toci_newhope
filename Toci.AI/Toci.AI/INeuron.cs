using System.Collections;
using System.Collections.Generic;

namespace Toci.AI
{
    public interface INeuron<TTrainedNode> where TTrainedNode : ITrainedNode

    {
    IEnumerable<TTrainedNode> SynapseCollection { get; set; }
    }
}