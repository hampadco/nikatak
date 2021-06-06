using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers {
    [Area ("Admin")]
    public class BimehController : BaseController {
        public BimehController(ContextHampadco _db, IWebHostEnvironment env) : base(_db, env)
        {
        }
        public IActionResult Index () {

            return View ();
        }
        public IActionResult Azmon () {

            return View ();
        }
        public IActionResult sales () {

            return View ();
        }
        public IActionResult Badaneh () {

            return View ();
        }
        public IActionResult Motor () {

            return View ();
        }
        public IActionResult Zelzeleh () {

            return View ();
        }
        public IActionResult AtashSoozi () {

            return View ();
        }
        public IActionResult Mosaferati () {

            return View ();
        }
        public IActionResult Pezeshki () {

            return View ();
        }
        public IActionResult Darmani () {

            return View ();
        }
        public IActionResult Omr () {

            return View ();
        }
    }
}