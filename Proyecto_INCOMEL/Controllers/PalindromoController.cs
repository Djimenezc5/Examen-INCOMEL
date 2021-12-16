using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_INCOMEL.Controllers
{
    public class PalindromoController : Controller
    {
        [Authorize]
        // GET: Palindromo
        public ActionResult Index()
        {
            return View();
        }
    }
}