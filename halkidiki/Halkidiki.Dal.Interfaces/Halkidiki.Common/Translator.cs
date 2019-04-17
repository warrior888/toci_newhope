using Halkidiki.Common.Interfaces;
using System.Collections.Generic;

namespace Halkidiki.Common
{
    public abstract class Translator<TTranslationEngine, TTranslationCandidate, TTranslationResult> : ITranslator<TTranslationEngine, TTranslationCandidate, TTranslationResult>
        where TTranslationCandidate : ITranslationCandidate
        where TTranslationResult : ITranslationResult
    {
        public abstract List<TTranslationResult> Translate(TTranslationCandidate candidates);
    }
}