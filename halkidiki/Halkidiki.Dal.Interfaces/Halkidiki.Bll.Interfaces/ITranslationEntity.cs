namespace Halkidiki.Bll.Interfaces
{
    public interface ITranslationEntity
    {
        string Language { get; set; }

        string SourceWord { get; set; }

        string TargetWord { get; set; }
    }
}