using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Halkidiki.Test;

namespace mamdosycdebili
{
    class Program
    {
        static void Main(string[] args)
        {
            GoogleTranslateTest t = new GoogleTranslateTest();
            //
            //t.TranslateGoogleTest();

            DalTests dt = new DalTests();

           dt.TestAddedLanguage();

         //   t.TranslateGoogleTest();

        }
    }
}
