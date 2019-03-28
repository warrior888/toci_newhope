using System.Collections.Generic;
using Halkidiki.Common.Interfaces;

namespace Halkidiki.Common
{
    public class TranslationCandidate : ITranslationCandidate
    {
        public List<string> Words { get; set; }
        public string LanguageFrom { get; set; }
        public string LanguageTo { get; set; }
    }
}