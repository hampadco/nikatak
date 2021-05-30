using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace Admin.Controllers {
    [Area ("Admin")]
    [Authorize]
    public class MenuController : BaseController
    { 

  public MenuController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
      {
          
      }

      
        public IActionResult Index () {
             Diposit();
            return View ();
        }

      

    }
}