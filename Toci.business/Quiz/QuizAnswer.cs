using Toci.Business.Interfaces;

namespace Toci.business.Quiz
{
    public class QuizAnswer :IQuizAnswer
    {
        public string Word { get; set; }
        public bool IsCorrect { get; set; }
    }
}