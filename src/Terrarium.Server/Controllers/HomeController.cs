using System;
using System.Web.Mvc;
using Terrarium.Server.Models;
using Terrarium.Server.ViewModels;

namespace Terrarium.Server.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usage()
        {
            var vm = new UsageViewModel();

            var alias = Request.QueryString["Alias"] ?? "Context.User.Identity.Name";
            vm.UserAliasLabel = alias;
            vm.UserTodayLabel = "0 hours";
            vm.UserWeekLabel = "0 hours";
            vm.UserTotalLabel = "0 hours";

            return View(vm);
        }

        public ActionResult Publish()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult UserInterface()
        {
            return View();
        }

        public ActionResult Tutorial()
        {
            return View();
        }

        public ActionResult Framework()
        {
            return View();
        }

        public ActionResult Samples()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult RandomTip()
        {
            // TODO get from IRepository
            var tip = new RandomTip();
            var random = new Random();
            tip.Tip = "Random Tip #" + random.Next(10, 300); //You can use Alt-Enter to enter a true Full-Screen view.
            // TODO map vm from model using AutoMapper
            var vm = new RandomTipViewModel();
            vm.Tip = tip.Tip;
            return PartialView("_RandomTips", vm);
        }
    }
}
