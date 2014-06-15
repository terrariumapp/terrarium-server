using System.Web.Mvc;
using Terrarium.Server.ViewModels;

namespace Terrarium.Server.Controllers
{
    public class UsageController : Controller
    {
        // GET: Usage
        public ActionResult Index()
        {
            var vm = new UsageViewModel();

            var alias = Request.QueryString["Alias"] ?? "Context.User.Identity.Name";
            vm.UserAliasLabel = alias;
            vm.UserTodayLabel = "0 hours";
            vm.UserWeekLabel = "0 hours";
            vm.UserTotalLabel = "0 hours";

            return View(vm);
        }
    }
}