using System;

namespace WordCount.Models
{
    public class WordCounter
    {
        private string _word;               //keyword
        private string _words;              //comparative word
        private string[] _wordArray;        //comparative word array
        private int _occurance;             //tallies instances of keyword

        public void SetWord(string word)
        {
            if (this.WordLettersOnly(word))
            {
                string LowCaseWord = word.ToLower();
                _word = LowCaseWord;
            }
            else
            {
                _word = String.Empty;
            }
        }

        public string GetWord(string word)
        {
            return _word;
        }

        public bool WordLettersOnly(string word)
        {
            char[] letterArray = word.ToCharArray();
            foreach (char x in letterArray)
            {
                if(Char.IsLetter(x))
                {
                    return true;
                }
            }
            return false;
        }

        public void SetWords(string words)
        {
            if (this.WordsLettersOnly(words))
            {
                string LowCaseWords = words.ToLower();
                _words = LowCaseWords;
            }
            else
            {
                _words = String.Empty;
            }
        }

        public string GetWords(string words)
        {
            return _words;
        }

        public bool WordsLettersOnly(string words)
        {
            char[] lettersArray = words.ToCharArray();
            foreach (char x in lettersArray)
            {
                if (Char.IsLetter(x))
                {
                    return true;
                }
            }
            return false;
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

        public void SetOccurTally(int score)
        {
            _occurance = score;
        }

        public int GetOccurTally()
        {
            _occurance = 0;
            return _occurance;
        }

        //public string wordToCheck = GetWord(word);
        //public string[] arrayToCheck = listArray[];
        //foreach (string x in arrayToCheck)
        //{
        //    foreach (arrayToCheck.Contains(x))
        //    {
        //        wordOccur ++;
        //    }    
        //}            

    }
}