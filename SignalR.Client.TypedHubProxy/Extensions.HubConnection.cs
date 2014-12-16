﻿namespace Microsoft.AspNet.SignalR.Client
{
    public static partial class SignalRTypedHubProxyExtensions
    {
        /// <summary>
        ///     Creates a strongly typed proxy for the hub with the specified name.
        /// </summary>
        /// <param name="connection">The <see cref="T:Microsoft.AspNet.SignalR.Client.HubConnection" />HubConnection.</param>
        /// <param name="hubName">The name of the hub.</param>
        /// <typeparam name="TServerHubInterface"></typeparam>
        /// <typeparam name="TClientInterface"></typeparam>
        public static ITypedHubProxy<TServerHubInterface, TClientInterface> CreateHubProxy
            <TServerHubInterface, TClientInterface>(this HubConnection connection,
                string hubName)
            where TServerHubInterface : class
            where TClientInterface : class
        {
            return new TypedHubProxy<TServerHubInterface, TClientInterface>(connection, hubName);
        }
    }
}