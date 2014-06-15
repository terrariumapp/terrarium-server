namespace Terrarium.Server.Models
{
    /// <summary>
    /// This enum contains the values for different
    /// response codes when a client calls RegisterMyPeerGetCountAndPeerList.
    /// Success means the call was good. Failure is generally a database
    /// timeout or other database issue, whereas a GlobalFailure means we
    /// have disabled that version of the client and wish the user to upgrade.
    /// </summary>
    public enum RegisterPeerResult
    {
        /// <summary>
        /// Indicates successful registration of a peer connection.
        /// </summary>
        Success,
        /// <summary>
        /// Indicates an unsuccessful attempt to register a peer connection.
        /// </summary>
        Failure,
        /// <summary>
        /// Indicates an unsuccessful attempt to register a peer connection.
        /// </summary>
        GlobalFailure
    }
}