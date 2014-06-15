using System.Collections.Generic;
using System.Web.Http;
using Terrarium.Server.Models;

namespace Terrarium.Server.Controllers
{
    /// <summary>
    /// The chart service is capable of providing remote clients
    /// with charting data by calling on the local charting components to
    /// generate the chart and then returning any required information to the
    /// remote client to display the chart.  This service is also capable of
    /// returning all the data required to produce a remote interface to
    /// graph generation and the information required to generate top-n reports.
    /// </summary>
    public class ChartController : ApiController
    {
        /// <summary>
        /// Returns a graph of ALL species along with their latest
        /// point of population data.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<object> GetSpeciesList()
        {
            return null;
        }

        /// <summary>
        /// Returns the latest datapoint of statistics information
        /// for a given species in the form of a dataset.
        /// </summary>
        /// <param name="species"></param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<object> GrabLatestSpeciesData(string species)
        {
            return null;
        }

        /// <summary>
        /// Returns various information about the top-num animals
        /// of a given organism type for use in top-n reporting.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="tat"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<object> GetTopAnimals(string version, OrganismType tat, int num)
        {
            return null;
        }
    }
}
