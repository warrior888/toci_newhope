using System;
using Halkidiki.Dal;
using Halkidiki.Dal.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Halkidiki.Bll;

namespace Halkidiki.Test
{
    [TestClass]
    public class DalTests
    {
        [TestMethod]
        public void TestDeleteFromLanguages()
        {
            IDal<language> dal = new Dal<language>();

            language lng = new language() { id = 1 };

            int insRows = dal.Insert(lng);

            Assert.AreEqual(1, insRows);

            int affRows = dal.Delete(lng);

            Assert.AreEqual(0, affRows);
        }

        [TestMethod]
        public void TestAddedLanguage()
        {
            SentenceManipulator sen = new SentenceManipulator();

            sen.CheckAddLanguage("pl");
            sen.CheckAddLanguage("pl");




        }

    }
}
