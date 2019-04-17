using System;
using System.Linq.Expressions;

namespace Halkidiki.Dal.Interfaces
{
    public interface ISelectSql<TModel, TOrderByKey>
    {
        Expression<Func<TModel, bool>> Where { get; set; }

        Expression<Func<TModel, TOrderByKey>> OrderBy { get; set; }

        bool Order { get; set; }
    }
}