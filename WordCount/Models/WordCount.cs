using System;

namespace WordCount.Models
{
    public class WordCounter
    {
        private string _word;               //word
        private string _words;              //comparative word
        private string[] _wordArray;        //comparative word array
        //private string _match;              //word match
        //private int _wordOccur = 0;         //word match score/occurences

        public void SetWord(string word)
        {
            _word = word;
        }

        public string GetWord(string word)
        {
            return _word;
        }

        public void SetWords(string words)
        {
            _words = words;
        }

        public string GetWords(string words)
        {
            return _words;
        }

        public void SetArray(string[] cutWords)
        {
            _wordArray = cutWords;
        }

        public string[] GetArray()
        {
            return _wordArray;
        }

        public string[] splitString(string words)
        {
            string[] listArray = words.Split();
            SetArray(listArray);
            return GetArray();
        }
    }
}