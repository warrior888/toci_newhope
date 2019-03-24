namespace Halkidiki.Bll.Interfaces
{
    public interface ISentenceManipulator
    {
        bool AcceptSentence(int userId, string sentence, int languageId);

        ITranslationEntity Translate(string word, string destinationLanguage);
    }
}