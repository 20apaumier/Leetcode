using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode.ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayString.Tests
{
    [TestClass()]
    public class ReverseWordsStringTests
    {
        [TestMethod()]
        public void ReverseWordsTest()
        {
            // Arramge
            string s = "the sky is blue";
            ReverseWordsString rws = new ReverseWordsString();

            // Act
            string result = rws.ReverseWords(s);
            string expected = "blue is sky the";

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}