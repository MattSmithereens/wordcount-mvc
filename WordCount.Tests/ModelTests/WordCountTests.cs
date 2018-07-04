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
        public void GetSetUserWord_GetsSetsUserWord_String()
        {
            //word setter PASSED
            //Arrange
            WordCounter testWordCount = new WordCounter();
            string testWord = "crash";

            //Act
            testWordCount.SetWord(testWord);

            //Assert
            Assert.AreEqual("crash", testWordCount.GetWord(testWord));
        }

        [TestMethod]
        public void GetSetUserWords_GetsSetsUserWords_String()
        {
            //word2 setter PASSED
            //Arrange
            WordCounter testWordCount = new WordCounter();
            string testWord = "bang bang bang";

            //Act
            testWordCount.SetWords(testWord);

            //Assert
            Assert.AreEqual("bang bang bang", testWordCount.GetWords(testWord));
        }

        [TestMethod]
        public void GetsWordsString_SplitsStringToArray_String()
        {
            //words to array
            //Arrange
            WordCounter testWordCount = new WordCounter();

            //Act
            string words = "crash bang boom";
            string[] testList = { "crash", "bang", "boom" };

            //Assert
            CollectionAssert.AreEqual(testList, testWordCount.splitString(words));
        }
    }
}
