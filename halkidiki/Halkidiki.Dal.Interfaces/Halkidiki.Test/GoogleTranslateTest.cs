using System.Collections.Generic;
using Halkidiki.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Halkidiki.Test
{
    [TestClass]
    public class GoogleTranslateTest
    {
        [TestMethod]
        public void TranslateGoogleTest()

        {
            GoogleTranslator googleTranslator = new GoogleTranslator();

            TranslationCandidate candidate = new TranslationCandidate()
            {
                LanguageFrom = "pl",
                LanguageTo = "es",
                Words = new List<string>()
                {
                    "co",
                    "dom"
                }
            };

            List<TranslationResult> result = googleTranslator.Translate(candidate);
        }
    }
}