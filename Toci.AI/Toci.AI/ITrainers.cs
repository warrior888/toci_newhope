using System.Collections;
using System.Collections.Generic;

namespace Toci.AI
{
    public interface ITrainers<TTrainers>
    {
        IEnumerable<TTrainers> Trainers { get; set; }
    }
}