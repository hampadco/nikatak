using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using faraboom.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModels.AdminViewModel.User;

namespace faraboom.Areas.Adminsite.Controllers {

    public class UsersNewController : BaseController {

        public UsersNewController (ContextHampadco _db, IWebHostEnvironment env) : base (_db, env) { }
        public IActionResult Index () {
            if (err != null) {
                ViewBag.er = err;
                err = null;
            }

            // List<Vm_User> us = new List<Vm_User> ();
            // var q = db.Tbl_User.OrderByDescending (a => a.Id).ToList ();
            // foreach (var item in q) {
            //     var b = db.Tbl_infos.Where (a => a.UserNameId == item.UserNameUs).SingleOrDefault ();
            //     if (b != null) {
            //         string d = null;
            //         if (b.Locationaddress == "ok") {
            //             d = "ok";
            //         }
            //         Vm_User ff = new Vm_User () {
            //             Id = item.Id,
            //             UserNameUs = item.UserNameUs,
            //             EmailUS = item.EmailUS,
            //             PhoneUs = item.PhoneUs,
            //             PasswordUs = item.PasswordUs,
            //             AddressUs = item.AddressUs,
            //             NameFamily = item.NameFamily,
            //             CodeMeli = item.CodeMeli,
            //             state = item.state,
            //             pay = d,
            //             ProfileImageUs=item.ProfileImageUs,

            //         };
            //         us.Add (ff);

            //     }
            // }

            // ViewBag.list = us.OrderByDescending (a => a.Id).ToList ();
            ViewBag.list=db.Tbl_infos.Where(a=>a.Typeactivity=="Request").ToList();

            return View ();
        }
        public IActionResult del (int id) {
            var selectdel = db.Tbl_infos.Where (a => a.Id == id).SingleOrDefault ();
            db.Tbl_infos.Remove (selectdel);
            db.SaveChanges ();
            err = "حذف با موفقیت انجام شد";
            return RedirectToAction ("index");
        }

    }
}