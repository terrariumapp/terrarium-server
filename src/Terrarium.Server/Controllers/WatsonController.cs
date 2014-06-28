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
    /// Enables logging of errors from Terrarium clients.
    /// </summary>
    public class WatsonController : ApiController
    {
        private readonly ITerrariumDbContext _context;

        public WatsonController(ITerrariumDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// <para>
        /// Takes an object from a client and inserts a record into the database.
        /// </para>
        /// <para>
        /// This is used by the Terrarium Client to submit application information in
        /// case a crash happens and is done automatically.
        /// </para>
        /// <para>
        /// The Id, MachineName, and DateSubmitted part of the Watson object are ignored
        /// and automatically filled in by the server.
        /// </para>
        /// </summary>
        /// <param name="data">Watson data object containing error information from the client application.</param>
        [HttpPost]
        [Route("api/watson")]
        public HttpResponseMessage ReportError(Watson data)
        {
            if (data == null)
            {
                throw new HttpResponseException(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Content = new StringContent("No Watson data provided")
                });
            }

            try
            {
                data.MachineName = RequestHelpers.GetClientIpAddress(Request);
                data.DateSubmitted = DateTime.Now;
                _context.AddError(data);
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
