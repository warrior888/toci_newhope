using Google.Apis.Services;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using System.Collections.Generic;
using System.Linq;
using TranslationsResource = Google.Apis.Translate.v2.Data.TranslationsResource;

namespace Halkidiki.Common
{
    public class GoogleTranslator : Translator<TranslateService, TranslationCandidate, TranslationResult>
    {
        public override List<TranslationResult> Translate(TranslationCandidate candidates)
        {
            TranslateService service = new TranslateService(new BaseClientService.Initializer() { ApiKey = "AIzaSyCV2_E3yw4z8wg2xO1pw6U3GVFr3nytaKM" });

            List<TranslationResult> trResult = new List<TranslationResult>();

            foreach (string oneWord in candidates.Words)
            {
                TranslationsListResponse result = service.Translations.List(new[] { oneWord }, candidates.LanguageTo).Execute();

                foreach (TranslationsResource translation in result.Translations)
                {
                    trResult.Add(GetTranslationResult(translation, candidates, oneWord));
                }
            }

            return trResult;
        }

        protected virtual TranslationResult GetTranslationResult(TranslationsResource resource, TranslationCandidate candidate, string word)
        {
            return new TranslationResult() { LanguageFrom = resource.DetectedSourceLanguage, LanguageTo = candidate.LanguageTo, WordFrom = word, WordTo = resource.TranslatedText };
        }
    }
}