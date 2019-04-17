namespace Halkidiki.Common.Interfaces
{
    public interface ITranslationResult
    {
        string LanguageFrom { get; set; }

        string LanguageTo { get; set; }

        string WordFrom { get; set; }

        string WordTo { get; set; }
    }
}