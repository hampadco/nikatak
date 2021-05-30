using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers {
    [Area ("Admin")]
    public class sazemanController : BaseController {
        public sazemanController(ContextHampadco _db, IWebHostEnvironment env) : base(_db, env)
        {
        }
        public IActionResult rgcaremeli () {

            return View ();
        }
        public IActionResult caremeli () {

            return View ();
        }

        public IActionResult ehraz_hoviyat () {

            return View ();
        }
        public IActionResult marsolepost () {

            return View ();
        }

        public IActionResult taidsalahiat () {

            return View ();
        }
        public IActionResult hogogi () {

            return View ();
        }

        public IActionResult tax () {

            return View ();
        }
        public IActionResult coderahgiri () {

            return View ();
        }


         public IActionResult salahiyat () {

            return View ();
        }
        public IActionResult job () {

            return View ();
        }

        public IActionResult vardat () {

            return View ();
        }
        public IActionResult estandard () {

            return View ();
        }

          public IActionResult sabt_tavoni () {

            return View ();
        }
        public IActionResult rg_tavoni () {

            return View ();
        }


        public IActionResult student () {

            return View ();
        }
        public IActionResult moshave_behzisti () {

            return View ();
        }

          public IActionResult rgkhayer () {

            return View ();
        }
        public IActionResult enemad () {

            return View ();
        }

          public IActionResult company () {

            return View ();
        }
        public IActionResult company2 () {

            return View ();
        }

    }
}