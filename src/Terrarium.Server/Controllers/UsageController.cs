using System.Web.Http;
using Terrarium.Server.Models;

namespace Terrarium.Server.Controllers
{
    /// <summary>
    /// Reports on usage of the system.
    /// </summary>
    public class UsageController : ApiController
    {
        /// <summary>
        /// Allows a client to report it's usage and adds it to the system.
        /// </summary>
        /// <param name="data">UsageData from the client about the current state.</param>
        public void ReportUsage(UsageData data)
        {
        }
    }
}
