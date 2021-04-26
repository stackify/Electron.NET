using Quobject.SocketIoClientDotNet.Client;

namespace ElectronNET.API
{
    /// <summary>
    /// Wrapper for the underlying Socket connection
    /// </summary>
    public class ApplicationSocket
    {
        /// <summary>
        /// Socket used to communicate with main.js
        /// </summary>
        public Socket Socket { get; internal set; }
    }
}
