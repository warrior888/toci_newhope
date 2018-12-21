using System.Collections.Generic;
using Toci.Business.Interfaces;

namespace Toci.business.Quiz
{
    public class Quiz : IQuiz
    {
        public IQuizQuestion Question { get; set; }
        public List<IQuizAnswer> Answers { get; set; }
        public List<IQuizAnswer> FakeAnswers { get; set; }
    }
}