using System.Data;

namespace Toci.business.Dal
{
    public class TranslationDal
    {
        protected DbAccessBase dbAccess = new PostgresqlDbAccess();

        public virtual bool Insert(string name, string language = "pl")
        {
            string query = "insert into word (name, language) values ('" + name + "', '" + language + "');";

            return dbAccess.ExecuteInsert(query);


        }

        public virtual DataTable GetTranslations(string toLanguage)
        {
            string query = "select * from WordTranslation where tolanguage = '" + toLanguage + "'";

            return dbAccess.ExecuteSelect(query);
        }
    }
}