using System.Collections.Generic;

namespace Halkidiki.Common.Interfaces
{
    public interface ITranslator<TTranslationEngine, in TTranslationCandidate, out TTranslationResult>
        where TTranslationCandidate : ITranslationCandidate
        where TTranslationResult : ITranslationResult
    {
        IEnumerable<TTranslationResult> Translate(TTranslationCandidate candidates);
    }
}