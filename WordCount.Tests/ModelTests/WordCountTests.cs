using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCount.Models;
using System;



namespace WordCount.Tests.ModelTests
{   
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void GetSetUserWord_SetsUserWordToLower_String()
        {
            // PASSED
            WordCounter testWordCount = new WordCounter();
            string testWord = "CRASH";
            string expected = "crash";
            testWordCount.SetWord(testWord);
            string actual = testWordCount.GetWord(testWord);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSetUserWords_SetsUserWordToLower_String()
        {
            // PASSED
            WordCounter testWordCount = new WordCounter();
            string testWords = "CRASH BANG BOOM";
            string expected = "crash bang boom";
            testWordCount.SetWords(testWords);
            string actual = testWordCount.GetWords(testWords);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetsWordsString_SplitsStringToArray_Array()
        {
            // PASSED
            WordCounter testWordCount = new WordCounter();
            string words = "crash bang boom";
            string[] actual = testWordCount.splitString(words);
            string[] expected = { "crash", "bang", "boom" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSetScore_SetsOccurScore_Int()
        {
            // PASSED
            WordCounter testWordCount = new WordCounter();;
            int expected = 0;
            int actual = testWordCount.GetOccurTally();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckWordAgainstSentenceWords_OccurenceRaisesScore_Int()
        {
            WordCounter testWordCount = new WordCounter();
            string keyWord = "bang";
            WordCounter.SetWord(keyWord);
            WordCounter.GetWord();
            string[] compareWords = { "chitty", "chitty", "bang", "bang" };
            int expected = 2;
            int actual = testWordCount.WordOccurs(compareWords);
            Assert.AreEqual(expected, actual);
        }
    }
}
