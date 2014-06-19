using System;
using System.Collections.Generic;
using System.Web.Http;
using Terrarium.Server.Models;

namespace Terrarium.Server.Controllers
{
    /// <summary>
    /// Encapsulates the functions required to insert new creatures into the
    /// ecosystem and get creatures from the server during a reintroduction.
    /// </summary>
    public class SpeciesController : ApiController
    {
        /// <summary>
        /// Gets a list of all species that have been blacklisted.
        /// </summary>
        /// <returns>The list of blacklisted species.</returns>
        [HttpGet]
        public IEnumerable<string> GetBlacklistedSpecies()
        {
            return null;
        }

        /// <summary>
        /// Returns a dataset of all species whose population has reached 0 and therefore can be reintroduced.
        /// </summary>
        /// <param name="version">The specific version of the species to get.</param>
        /// <param name="filter">The name of the species to filter or "All" for all available creatures.</param>
        /// <returns>A collection of creatures that meets the version and filter criteria</returns>
        [HttpGet]
        public object GetExtinctSpecies(string version, string filter)
        {
            return null;
        }

        /// <summary>
        /// Returns a dataset of all species given a specific version and filter criterion.
        /// </summary>
        /// <param name="version">The specific version of the species to get.</param>
        /// <param name="filter">The name of the species to filter or "All" for all available creatures.</param>
        /// <returns>A collection of creatures that meets the version and filter criteria</returns>
        [HttpGet]
        public object GetAllSpecies(string version, string filter)
        {
            return null;
        }

        /// <summary>
        /// Gets the assembly as a byte array for the species with a given name and version number.
        /// </summary>
        /// <param name="name">The name of the species to get</param>
        /// <param name="version">The version of the species to get</param>
        /// <returns>A byte array of the .NET assembly matching the criterion</returns>
        [HttpGet]
        public Byte[] GetSpeciesAssembly(string name, string version)
        {
            return null;
        }

        /// <summary>
        /// Introduces a previously extinct creature back into the EcoSystem and marks it as not extinct.
        /// </summary>
        /// <param name="name">The name of the species to reintroduce</param>
        /// <param name="version">The version of the species to reintroduce</param>
        /// <param name="peerGuid"></param>
        /// <returns>A byte array of the .NET assembly matching the criterion</returns>
        [HttpGet]
        public Byte[] ReintroduceSpecies(string name, string version, Guid peerGuid)
        {
            return null;
        }

        /// <summary>
        ///  This function takes a creature assembly, author information,
        ///  and a species name and attempts to insert the creature into the EcoSystem.
        ///  This involves adding the creature to the database and saving the assembly
        ///  on the server so it can later be used for reintroductions.
        ///  All strings are checked for inflammatory words and the insertion is not
        ///  performed if any are found.  In addition the 5 minute rule is checked to
        ///  make sure the user isn't spamming the server.  Only 1 upload is allowed
        ///  per 5 minutes.  An additional constraint of only 30 uploads per day is
        ///  also enforced through the 24 hour rule. 
        ///  
        ///  The creature is then inserted into the database.  If the creature already
        ///  exists the function tells the client the creature is preexisting and the
        ///  insert fails.  If the insert is successful the creature is then saved to disk on the server.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="type"></param>
        /// <param name="author"></param>
        /// <param name="email"></param>
        /// <param name="assemblyFullName"></param>
        /// <param name="assemblyCode"></param>
        /// <returns></returns>
        [HttpPost, HttpGet]
        public SpeciesServiceStatus Add(string name, string version, string type, string author, string email,
            string assemblyFullName, byte[] assemblyCode)
        {
            return SpeciesServiceStatus.Success;    
        }
    }
}
