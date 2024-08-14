using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
    [TestClass]
    public class BuyAndSellTests
    {
        [TestMethod]
        public void BuyAndSellTest()
        {
            // arrange 
            int[] prices = [7, 1, 5, 3, 6, 4];
            int expected = 5;

            // act
            int actual = BuyAndSell.MaxProfit(prices);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuyAndSellTest2()
        {
            // arrange 
            int[] prices = [7, 6, 4, 3, 1];
            int expected = 0;

            // act
            int actual = BuyAndSell.MaxProfit(prices);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuyAndSellTest3()
        {
            // arrange 
            int[] prices = [4, 6, 1, 14, 12, 1, 4, 19];
            int expected = 18;

            // act
            int actual = BuyAndSell.MaxProfit(prices);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}