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

        public virtual bool AcceptSentence(int userId, string sentence, int languageId)
        {
            // question to google for recognized language
            List<string> sentenceElements = ExplodeSentence(sentence);

            foreach(string word in sentenceElements)
            {
                translation t = translationDal.Select(new SelectSql<translation, string>() {Where = model => model.idlanguage == languageId && model.translation1 == word}).First();


            }

            return true;
        }

        public virtual ITranslationEntity Translate(string word, string destinationLanguage)
        {
            throw new System.NotImplementedException();
        }

        protected virtual List<string> ExplodeSentence(string sentence)
        {
            return sentence.Split(new[] {SpaceSentenceDelimiter}, StringSplitOptions.None).ToList();
        }
    }
}