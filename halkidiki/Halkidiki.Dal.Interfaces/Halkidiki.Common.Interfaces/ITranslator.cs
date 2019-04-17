using System.Collections.Generic;

namespace Halkidiki.Common.Interfaces
{
    public interface ITranslator<TTRanslationEngine, TTranslationCandidate, TTranslationResult>
        where TTranslationCandidate : ITranslationCandidate
        where TTranslationResult : ITranslationResult
    {
        List<TTranslationResult> Translate(TTranslationCandidate candidates);
    }
}