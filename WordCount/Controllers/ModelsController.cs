using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCount.Models;

namespace WordCount.Controllers
{
    public class ModelsController : Controller
    {

        [Route("/formLib")]
        public ActionResult WordCompare()
        {
            WordCounter inputVariable = new WordCounter();
            inputVariable.SetWord(Request.Query["checkWord"]);
            inputVariable.SetWords(Request.Query["checkPhrase"]);
            return View("result", inputVariable);
        }



    }
}
