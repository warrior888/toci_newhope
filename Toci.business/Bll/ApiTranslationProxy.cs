using System.Collections.Generic;
using System.Linq;
using Google.Apis.Services;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using Toci.business.Dal;

namespace Toci.business.Bll
{
    public class ApiTranslationProxy
    {
        //Dictionary<int, List<int>> translationMap = new Dictionary<int, List<int>>();
        private List<int> translationMap = new List<int>();
        TranslationDal dal = new TranslationDal();

        public virtual string Translate(string word, string toLanguage)
        {
            Google.Apis.Translate.v2.TranslateService service = new TranslateService(new BaseClientService.Initializer() { ApiKey = "AIzaSyCV2_E3yw4z8wg2xO1pw6U3GVFr3nytaKM" });
           

            TranslationsListResponse result = service.Translations.List(new[] { word }, toLanguage).Execute();


            return result.Translations.First().TranslatedText;
        }

        public virtual void AddTranslation(string word)
        {
            string[] languages = { "pl", "en", "de", "nl", "es", "it" };
            
            foreach (string language in languages)
            {
                string toWord = Translate(word, language);

                translationMap.Add(dal.Insert(toWord, language));
                // 5 6 7 8 9 10
                
               // translationProxy.AddTranslation(textBox1.Text, language);
            }

            foreach (int id in translationMap)
            {
                foreach (int idChild in translationMap)
                {
                    if (id == idChild)
                        continue;

                    dal.InsertToTranslationmap(id, idChild);
                }
            }

        }
    }
}