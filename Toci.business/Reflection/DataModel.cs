using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Binder = Microsoft.CSharp.RuntimeBinder.Binder;

namespace Toci.business.Reflection
{
    public class DataModel
    {
        public static int Sex {get;set;}
        public int HairColour {get;set;}
        public int Age {get;set;}
        public int Height {get;set;}
        public int Weight {get;set;}

        private string ToDaSieWypelnicRefleksja { get; set; }
    }

    public class ReflectionExample
    {
        public List<string> GetProperties<TEntity>(TEntity entity)
        {
            return entity.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public).Select(property => property.Name).ToList();
        }

        public List<string> GetDataModelProperties()
        {
            return GetProperties(new DataModel());
        }

        public void SetPrivateField<TEntity, TFieldValue>(TEntity ent, TFieldValue fieldValue, string fieldName)
        {
            //PropertyInfo property = ent.GetType().GetProperty(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);

            //property.SetValue(ent, fieldValue);
        }

        public void RunGenericMethodByString(ReflectionExample re, string methodName, Type[] genericParams, DataModel dm)
        {
            MethodInfo mi = re.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);



            mi.MakeGenericMethod(genericParams);

            mi.Invoke(re, new object[] { dm, "tylek", "ToDaSieWypelnicRefleksja" } );
        }
    }
}