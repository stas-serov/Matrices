using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab4;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void test_operation1()
        {
            Operations op = new Operations();
            int[,] expected = new int[,] { { 120, 121, 173, 377, 434 }, { 90, 211, 422, 425, 439 }, { 100, 151, 172, 268, 521 }, { 21, 47, 432, 447, 595 }, { 66, 130, 203, 309, 481 } };
            int[,] actual = op.sort_rows(new int[,]{ { 434, 173, 121, 120, 377 }, { 90, 422, 439, 425, 211 }, { 521, 172, 100, 268, 151 }, { 595, 47, 21, 447, 432 }, { 481, 130, 309, 203, 66 } }, 5);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_operation2()
        {
            Operations op = new Operations();
            int expected = 174;
            int actual = op.determine_element(new int[,] { {533, 447, 374, 199, 492}, {17, 316, 324, 174, 169}, {124, 130, 111, 188, 159}, {148, 145, 392, 236, 118}, {71, 199, 484, 283, 357} }, 1, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_operation3()
        {
            Operations op = new Operations();
            int[,] expected = new int[,] { {0, 175, 272, 0, 585}, {313, 540, 0, 434, 457}, {156, 0, 546, 224, 0}, {0, 316, 388, 0, 416}, {173, 575, 0, 456, 30} };
            int[,] actual = op.sum_indexes_devisible_3(new int[,] { { 542, 175, 272, 121, 585 }, {313, 540, 391, 434, 457}, {156, 196, 546, 224, 77}, {47, 316, 388, 309, 416}, {173, 575, 543, 456, 30}}, 0, 5);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
