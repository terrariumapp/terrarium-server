using System.Web.Http;
using Terrarium.Server.Models;

namespace Terrarium.Server.Controllers
{
    public class BugController : ApiController
    {
        /// <summary>
        /// Report a real bug with Terrarium
        /// </summary>
        /// <param name="bug">Information from the client with details of the bug</param>
        public void ReportBug(Bug bug)
        {
            // TODO
        }
    }
}
