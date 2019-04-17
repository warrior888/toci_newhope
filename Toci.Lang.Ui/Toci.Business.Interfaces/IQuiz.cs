using System.Collections.Generic;

namespace Toci.Business.Interfaces
{
    public interface IQuiz
    {
        IQuizQuestion Question { get; set; }

        List<IQuizAnswer> Answers { get; set; }

        List<IQuizAnswer> FakeAnswers { get; set; }
    }
}