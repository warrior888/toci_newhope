using System;
using System.Collections.Generic;
using System.Linq;
using Halkidiki.Bll.Interfaces;
using Halkidiki.Dal;
using Halkidiki.Dal.Interfaces;

namespace Halkidiki.Bll
{
    public class SentenceManipulator : ISentenceManipulator
    {
        public const string SpaceSentenceDelimiter = " ";

        protected IDal<word> WordDal = new Dal<word>();
        protected IDal<translation> translationDal = new Dal<translation>();

        public virtual bool AcceptSentence(int userId, string sentence, string languageFrom, string languageTo)
        {
            List<string> sentenceElements = ExplodeSentence(sentence);

            foreach(string word in sentenceElements)
            {
                translation t = translationDal.Select(new SelectSql<translation, string>() {Where = model => model.language.language1 == languageFrom && model.translation1 == word}).First();


            }

            return true;
        }

        protected virtual List<string> ExplodeSentence(string sentence)
        {
            return sentence.Split(new[] {SpaceSentenceDelimiter}, StringSplitOptions.None).ToList();
        }
    }
}