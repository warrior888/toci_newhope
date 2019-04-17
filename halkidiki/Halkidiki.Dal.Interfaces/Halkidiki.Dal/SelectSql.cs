using System;
using System.Linq.Expressions;
using Halkidiki.Dal.Interfaces;

namespace Halkidiki.Dal
{
    public class SelectSql<TModel, TOrderBy> : ISelectSql<TModel, TOrderBy>
    {
        public Expression<Func<TModel, bool>> Where { get; set; }
        public Expression<Func<TModel, TOrderBy>> OrderBy { get; set; }
        public bool Order { get; set; }
    }
}