using System.Collections.Generic;

namespace Halkidiki.Common.Interfaces
{
    public interface ITranslationCandidate
    {
        List<string> Words { get; set; }

        string LanguageFrom { get; set; }

        string LanguageTo { get; set; }
    }
}