using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WordCount.Models;

namespace WordCount.Controllers
{
    public class ModelsController : Controller
    {
        
        [Route("/formLib")]
        public ActionResult WordCompare()
        {
            // display inputted words in result sentence
            WordCounter inputVariable = new WordCounter();
            inputVariable.SetWord(Request.Query["checkWord"]);
            inputVariable.SetWords(Request.Query["checkPhrase"]);
            //if (GetWord("checkword") == "")
            //{
            //    return View("error");
            //}
            //    else
            //{
                return View("result", inputVariable);
            //}
        }

        // Breaks build

        //[HttpPost("/result")]
        //public ActionResult WordInput()
        //{
        //    WordCounter solution = new WordCounter();
        //    solution.SetWord(Request.Query["checkWord"]);
        //    solution.SetWords(Request.Query["checkPhrase"]);
        //    string lowCaseWord = solution.LowCaseWord();
        //    string[] compareWords = solution.splitString(cutWords);
        //    solution.WordOccurs(compareWords, lowCaseWord);
        //    return View(result);
        //}
    }
}
