using System.Web.Http;
using Terrarium.Server.Models;

namespace Terrarium.Server.Controllers
{
    /// <summary>
    /// Allows users to submit bug reports to the server
    /// </summary>
    public class BugController : ApiController
    {
        /// <summary>
        /// Report a real bug with Terrarium
        /// </summary>
        /// <param name="bug">Information from the client with details of the bug</param>
        [HttpPost]
        public void ReportBug(Bug bug)
        {
            // TODO
        }
    }
}
