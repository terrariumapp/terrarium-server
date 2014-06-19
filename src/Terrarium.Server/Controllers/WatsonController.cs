using System.Web.Http;
using Terrarium.Server.Models;

namespace Terrarium.Server.Controllers
{
    /// <summary>
    /// Enables logging of errors from Terrarium clients.
    /// </summary>
    public class WatsonController : ApiController
    {
        /// <summary>
        /// Takes an object from a client and inserts a record into the database.
        /// </summary>
        /// <param name="data">Watson object containing error information.</param>
        [HttpPost]
        public void ReportError(Watson data)
        {
            // TODO
        }
    }
}
