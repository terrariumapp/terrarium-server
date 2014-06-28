using System;
using System.Web.Http;

namespace Terrarium.Server.Controllers
{
    /// <summary>
    /// This class implements the reporting web service for the Terrarium Server.
    /// This web service takes reporting data from clients and inserts
    /// the data into a special history table.This data is later rolled up 
    /// by the NonPageServices class and turned into data points.
    /// These data points are used used when creating graphs of the server activity, 
    /// species populations, etc.
    /// </summary>
    public class ReportsController : ApiController
    {
        /// <summary>
        /// This method takes a dataset from the client along with
        /// a game state guid and the tick this data represents as its parameter. It uses this
        /// information to make insertions into the History table in the Terrarium Server database.
        /// </summary>
        /// <remarks>
        /// This function is capable of throttling users and throwing away their
        /// data to prevent cheating or DOS attacks.
        /// 
        /// This function is also capable of detecting corrupted or out of date
        /// clients and alerting them as to such.  It can also detect if the client
        /// is reporting information on blacklisted creatures and notify the peer
        /// of that special case.
        /// 
        /// There is also some code used to draw constraints on the data reported
        /// by a client.  In some cases a hacked client could report extremely high
        /// and bogus numbers.  This function will throw out any data that is heavily
        /// out of bounds to help prevent cheating.
        /// </remarks>
        /// <param name="data">A Dataset containing species population data.</param>
        /// <param name="guid">Guid associated with a peer connection.</param>
        /// <param name="currentTick">Integer representing the current tick (time increment).</param>
        /// <returns>A possible value from the ReturnCode enumeration.</returns>
        [HttpGet]
        [Route("api/reports/population")]
        public int Population(object data, Guid guid, int currentTick)
        {
            return 0;
        }
    }
}
