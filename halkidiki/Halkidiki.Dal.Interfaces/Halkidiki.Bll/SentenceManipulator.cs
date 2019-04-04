using System;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Translate.v2;
using Halkidiki.Bll.Interfaces;
using Halkidiki.Common;
using Halkidiki.Common.Interfaces;
using Halkidiki.Dal;
using Halkidiki.Dal.Interfaces;

namespace Halkidiki.Bll
{
    public class SentenceManipulator : ISentenceManipulator
    {
        public const string SpaceSentenceDelimiter = " ";

        protected IDal<word> WordDal = new Dal<word>();
        protected IDal<translation> translationDal = new Dal<translation>();
        protected IDal<language> languageDal = new Dal<language>();

        protected ITranslator<TranslateService, TranslationCandidate, ITranslationResult> google = new GoogleTranslator();

        public virtual bool AcceptSentence(int userId, string sentence, string languageFrom, string languageTo)
        {
            List<string> sentenceElements = ExplodeSentence(sentence);

            foreach(string word in sentenceElements)
            {
                translation t = translationDal.Select(new SelectSql<translation, string>() {Where = model => model.language.language1 == languageFrom && model.translation1 == word}).First();



            }

            return true;
        }

        public virtual int CheckAddWord(string word, string language)
        {
            word wordModel = WordDal.Select(new SelectSql<word, string>() {Where = x => x.word1 == word && x.translation.Where(t => t.language.language1 == language).Any()}).First();
            CheckAddLanguage(language);
            if (wordModel == null)
            {
                return WordDal.Insert(new word() {word1 = word});
            }

            return 0;
        }

        public virtual int CheckAddLanguage (string language)
        {
            language lang = languageDal.Select(new SelectSql<language, string>() {Where = x => x.language1 == language}).First();
            if(lang == null)
            {
               return languageDal.Insert(new language() {language1 = language});
                 
            }

            return 0;
        }

        protected virtual List<string> ExplodeSentence(string sentence)
        {
            return sentence.Split(new[] {SpaceSentenceDelimiter}, StringSplitOptions.None).ToList();
        }
    }
}