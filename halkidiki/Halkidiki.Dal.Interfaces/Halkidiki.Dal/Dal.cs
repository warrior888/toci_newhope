using System.Collections.Generic;
using System.Data.Entity;
using Halkidiki.Dal.Interfaces;

namespace Halkidiki.Dal
{
    //http://www.tugberkugurlu.com/archive/generic-repository-pattern-entity-framework-asp-net-mvc-and-unit-testing-triangle
    public class Dal<TModel> : IDal<TModel> where TModel : class
    {
        public virtual int Delete(TModel model)
        {
            halkidikiEntities entities = new halkidikiEntities();

            DbSet<TModel> entity = entities.Set<TModel>();
            entity.Remove(model);

            return entities.SaveChanges();

            //https://stackoverflow.com/questions/39131108/generic-insert-or-update-for-entity-framework

            
        }

        public virtual int Insert(TModel model)
        {
            halkidikiEntities entities = new halkidikiEntities();

            DbSet<TModel> entity = entities.Set<TModel>();
            entity.Add(model);

            return entities.SaveChanges();
        }

        public virtual List<TModel> Select(TModel model)
        {
            throw new System.NotImplementedException();
        }

        public virtual int Update(TModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}