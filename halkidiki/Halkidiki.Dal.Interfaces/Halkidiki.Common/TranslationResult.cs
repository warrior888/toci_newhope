using Halkidiki.Common.Interfaces;

namespace Halkidiki.Common
{
    public class TranslationResult : ITranslationResult
    {
        public string LanguageFrom { get; set ; }
        public string LanguageTo { get ; set ; }
        public string WordFrom { get ; set ; }
        public string WordTo { get ; set; }
    }
}