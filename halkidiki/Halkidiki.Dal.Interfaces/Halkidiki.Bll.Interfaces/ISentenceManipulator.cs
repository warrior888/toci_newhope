namespace Halkidiki.Bll.Interfaces
{
    public interface ISentenceManipulator
    {
        bool AcceptSentence(int userId, string sentence, string languageFrom, string languageTo);
    }
}