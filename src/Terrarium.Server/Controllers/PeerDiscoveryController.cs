using System;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Terrarium.Server.Models;

namespace Terrarium.Server.Controllers
{
    /// <summary>
    /// The Peer Discovery Service is the central location where
    /// peers can announce their existence and get information about other
    /// peers.  The primary services here are registering a user's email address,
    /// getting peer counts and lists, and registering a peer.
    /// </summary>
    public class PeerDiscoveryController : ApiController
    {
        /// <summary>
        /// Registers a Terrarium client user into the server database.
        /// </summary>
        /// <param name="email">E-mail address of the Terrarium user</param>
        /// <returns>Boolean indicating success or failure of the user registration.</returns>
        [HttpGet]
        public string RegisterUser(string email)
        {
            var ipAddress = GetClientIpAddress(Request);
            return ipAddress;
        }

        /// <summary>
        /// Obtains the number of peers currently connected to the Terrarium Server.
        /// </summary>
        /// <param name="version">String specifying the version number.</param>
        /// <param name="channel">String specifying the channel number.</param>
        /// <returns>Integer count of the number of peers for the specified version and channel number.</returns>
        [HttpGet]
        public int GetNumPeers(string version, string channel)
        {
            return 10;
        }

        /// <summary>
        /// Validates a peer connection.
        /// </summary>
        /// <returns>A string representing the "REMOTE_ADDR" attribute from the Web Application ServerVariables collection.</returns>
        [HttpGet]
        public string ValidatePeer()
        {
            return string.Empty;
        }

        /// <summary>
        /// Checks to see if a specific version is disabled or not.  Used by the client at start up.
        /// This allows an admin to totally shutdown a version.
        /// </summary>
        /// <param name="version">String specifying the version number.</param>
        /// <returns>A PeerVersionResult object containing the results of the query</returns>
        [HttpGet]
        public PeerVersionResult IsVersionDisabled(string version)
        {
            var result = new PeerVersionResult();

            result.Result = false;
            result.ErrorMessage = string.Empty;

            return result;
        }

        /// <summary>
        /// Registers a peer connection with the Terrarium Server.
        /// </summary>
        /// <param name="version">String specifying the version number.</param>
        /// <param name="channel">String specifying the channel number.</param>
        /// <param name="guid">Guid (Globally Unique Identifier) for the peer connection.</param>
        /// <returns>A PeerRegisterResult object containing the registration result</returns>
        [HttpPost]
        public PeerRegisterResult RegisterMyPeerGetCountAndPeerList(string version, string channel, Guid guid)
        {
            var result = new PeerRegisterResult();

            result.Peers = null;
            result.Count = 0;
            result.Result = RegisterPeerResult.Success;

            return result;
        }

        public static string GetClientIpAddress(HttpRequestMessage request)
        {
            if (request.Properties.ContainsKey("MS_HttpContext"))
            {
                return ((HttpContextBase)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            }
            throw new Exception("Client IP Address Not Found in HttpRequest");
        }
    }
}
