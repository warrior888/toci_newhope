using System.Collections.Generic;
using System.Data;
using Toci.business.Dal;
using Toci.business.Quiz.Interfaces;
using Toci.Business.Interfaces;
using IQuizAnswer = Toci.Business.Interfaces.IQuizAnswer;
using IQuizLogic = Toci.Business.Interfaces.IQuizLogic;

namespace Toci.business.Quiz
{
    public class QuizLogic : IQuizLogic
    {
        TranslationDal TrDal = new TranslationDal();
        public List<IQuiz> GetQuiz(string fromLanguage, string toLanguage)
        {
            DataTable result = TrDal.GetTranslationsFromTo(fromLanguage, toLanguage);

            List<IQuiz> quiz = new List<IQuiz>();

            foreach (DataRow row in result.Rows)
            {
                quiz.Add(GetQuizQuestion(row, result.Rows));
            }

            return quiz;
        }

        protected virtual IQuiz GetQuizQuestion(DataRow row, DataRowCollection fakeAnswers)
            
        {
            IQuiz question = new Quiz();

            question.Question = new QuizQuestion();
            question.Answers = new List<IQuizAnswer>();
            question.FakeAnswers = new List<IQuizAnswer>();

            question.Question.Word = row["fromword"].ToString();
            question.Answers.Add(new QuizAnswer(){IsCorrect = true, Word = row["toword"].ToString()});
            foreach (DataRow fakeanswer in fakeAnswers)
            {
                question.Answers.Add(new QuizAnswer() { Word = fakeanswer["toword"].ToString() });
            }
            
            return question;
        }
    }
}