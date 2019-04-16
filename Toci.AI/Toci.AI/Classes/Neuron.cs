using System.Collections.Generic;

namespace Toci.AI.Classes
{
    public class Neuron<TTrainedNode> : INeuron<TTrainedNode>
    {
        public IEnumerable<TTrainedNode> SynapseCollection { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}