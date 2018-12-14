using System.Data;

namespace Toci.business.Dal
{
    public class TranslationDal : PostgresqlDbAccess
    {
        

        public virtual int Insert(string name, string language = "pl")
        {
            string query = "insert into word (name, language) values ('" + name + "', '" + language + "') returning id;";

            return ExecuteInsert(query);


        }

        public virtual int InsertToTranslationmap(int idWord, int idWordChild) //translationmap
        {
             string query = "insert into translationmap (id_word, id_word_child) values (" + idWord + ", " + idWordChild + ") returning id;";

            return ExecuteInsert(query);  
        }

        public virtual DataTable GetTranslations(string toLanguage)
        {
            string query = "select * from WordTranslation where tolanguage = '" + toLanguage + "'";

            return ExecuteSelect(query);
        }
    }
}