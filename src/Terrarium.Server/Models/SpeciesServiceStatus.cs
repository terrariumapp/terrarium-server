namespace Terrarium.Server.Models
{
    /// <summary>
    /// This enumeration contains return codes identifying
    /// the results of an creature insertion into the Terrarium.
    /// Success identifies an inserted creature.  AlreadyExists means
    /// the creatures name has already been taken and a new name must be given.
    /// ServerDown means that a database error occured and the creature
    /// was not submitted.  VersionIncompatible is used when the required
    /// parameters aren't sent to the function.  FiveMinuteThrottle is
    /// returned whenever a user tries to submit more than one animal
    /// per 5 minutes.  TwentyFourHourThrottle occurs whenever a user
    /// tries to submit more than 30 creatures in a 24 hour period.			
    /// The last three are used whenever a passed string fails policheck.	
    /// Each enum value identifies a failure in a different string, whether
    /// the species name, author name, or the email has an questionable value.
    /// </summary>
    public enum SpeciesServiceStatus
    {
        Success,
        AlreadyExists,
        ServerDown,
        VersionIncompatible,
        FiveMinuteThrottle,
        TwentyFourHourThrottle,
        PoliCheckSpeciesNameFailure,
        PoliCheckAuthorNameFailure,
        PoliCheckEmailFailure
    }
}