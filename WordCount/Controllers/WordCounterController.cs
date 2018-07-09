using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WordCount.Models;

namespace WordCount.Controllers
{
    public class WordCounterController : Controller
    {

        [HttpGet("/form")]
        public ActionResult Form()
        {
            return View();
        }

        // Breaks build

        [HttpPost("/result")]
        public ActionResult Result()
        {
          WordCounter inputVariable = new WordCounter();
          inputVariable.SetWord(Request.Query["checkWord"]);
          inputVariable.SetWords(Request.Query["checkPhrase"]);

          // add call to method for counting words

           return View(result);
        }
    }
}
