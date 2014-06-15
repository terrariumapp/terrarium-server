using System.Web.Http;
using Terrarium.Server.Models;

namespace Terrarium.Server.Controllers
{
    /// <summary>
    /// Returns various informational messages from the server
    /// </summary>
    public class MessagingController : ApiController
    {
        /// <summary>
        /// Gets the welcome message for the server.
        /// </summary>
        /// <returns>The welcome message as stored in the web.config file or a stock one if we can't read it.</returns>
        public string GetWelcomeMessage()
        {
            try
            {
                return ServerSettings.WelcomeMessage;
            }
            catch
            {
                return "Welcome to .NET Terrarium!";
            }    
        }

        /// <summary>
        /// Gets the message of the day from the server.
        /// </summary>
        /// <returns>The message of the day as stored in the web.config file or a stock one if we can't read it.</returns>
        public string GetMessageOfTheDay()
        {
            try
            {
                return ServerSettings.MOTD;
            }
            catch
            {
                return "Have Fun!";
            }    
        }

        /// <summary>
        /// Gets the latest version of Terrarium from the server.
        /// </summary>
        /// <returns>The latest version as stored in the web.config file or a stock one if we can't read it.</returns>
        public string GetLatestVersion()
        {
            try
            {
                return ServerSettings.LatestVersion;
            }
            catch
            {
                return "1.0.0.0";
            }
        }
    }
}
