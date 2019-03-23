using System.Collections.Generic;

namespace Halkidiki.Dal.Interfaces
{
    public interface IDal<TModel> where TModel : class
    {
        int Insert(TModel model);

        int Update(TModel model);

        int Delete(TModel model);

        List<TModel> Select(TModel model);
    }
}