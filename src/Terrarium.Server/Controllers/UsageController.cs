using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Terrarium.Server.DataModels;
using Terrarium.Server.Infrastructure;
using Terrarium.Server.Models;

namespace Terrarium.Server.Controllers
{
    /// <summary>
    /// Reports on usage of the system.
    /// </summary>
    public class UsageController : ApiController
    {
        private readonly ITerrariumDbContext _context;

        public UsageController(ITerrariumDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// <para>
        /// Allows a client to report its own usage statistics and adds it to the system.
        /// </para>
        /// <para>
        /// The IPAddress portion of the UsageData object is automatically filled in by the server.
        /// </para>
        /// <para>
        /// Usage reporting is only allowed once every 60 minutes from a client.</para>
        /// </summary>
        /// <param name="data">UsageData from the client about the current state of their Terrarium.</param>
        [HttpPost]
        [Route("api/usage")]
        public HttpResponseMessage ReportUsage(Usage data)
        {
            if (data == null)
            {
                throw new HttpResponseException(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Content = new StringContent("No usage data provided")
                });
            }

            try
            {
                data.IPAddress = RequestHelpers.GetClientIpAddress(Request);
                _context.AddUsage(data);
            }
            catch (Exception e)
            {
                throw new HttpResponseException(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    Content = new StringContent(e.Message)
                });
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
