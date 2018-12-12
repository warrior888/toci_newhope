using System.Linq;
using Google.Apis.Services;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using Toci.business.Dal;

namespace Toci.business.Bll
{
    public class ApiTranslationProxy
    {
        TranslationDal dal = new TranslationDal();

        public virtual string Translate(string word, string toLanguage)
        {
            Google.Apis.Translate.v2.TranslateService service = new TranslateService(new BaseClientService.Initializer() { ApiKey = "AIzaSyCV2_E3yw4z8wg2xO1pw6U3GVFr3nytaKM" });


            TranslationsListResponse result = service.Translations.List(new[] { word }, toLanguage).Execute();


            return result.Translations.First().TranslatedText;
        }

        public virtual bool AddTranslation(string word, string language)
        {
            string toWord = Translate(word, language);

            return dal.Insert(toWord, language);
        }
    }
}