using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using upload.Models;

namespace upload.Controllers
{
    public class SureController : Controller
    {
        private readonly ConnectionStringClass _cc;
        public SureController(ConnectionStringClass cc)
        {
            _cc = cc;
        }
        public IActionResult Index()
        {
            var results = _cc.imdb.ToList();
           
            return View(results);
        }
    }
}