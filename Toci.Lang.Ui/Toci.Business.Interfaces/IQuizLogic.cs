using System.Collections.Generic;

namespace Toci.Business.Interfaces
{
    public interface IQuizLogic
    {
        List<IQuiz> GetQuiz(string fromLanguage, string toLanguage);
    }
}