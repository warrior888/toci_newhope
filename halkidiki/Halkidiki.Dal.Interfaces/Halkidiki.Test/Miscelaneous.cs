using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Halkidiki.Test
{
    [TestClass]
    public class Miscelaneous
    {
        // MWojcik - 
        // MM - 25%
        // Mwojcichowski - 16%
        //BZ - 0


        //----- 649

        //wojciechowski - 6%
        // mazur - 20%
        // 1 - 650
        private int count = 0;
        [TestMethod]
        public void TestWordRedundance()
        {
            string text =
                String.Join(" ", File.ReadAllLines(@"C:\Users\Administrator\Documents\toci_newhope\halkidiki\Halkidiki.Dal.Interfaces\Halkidiki.Test\grey.txt"));
            string[] word = text.Split(new[] { ". ", "? ", "! " }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (string item in word)
            {
                count = word.Where(w => w == item).Count();
                if (count >= 1)
                {
                    if (!result.ContainsKey(item))
                    result.Add(item, count);
                }
            }

            int allSentences = result.Select(m => m.Value).Sum();

            int dupa = 1;
        }
    }
}
