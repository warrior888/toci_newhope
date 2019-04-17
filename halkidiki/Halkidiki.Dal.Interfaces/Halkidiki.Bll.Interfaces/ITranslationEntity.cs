namespace Halkidiki.Bll.Interfaces
{
    public interface ITranslationEntity
    {
        string SourceLanguage { get; set; }

        string TargetLanguage { get; set; }

        string SourceWord { get; set; }

        string TargetWord { get; set; }
    }
}