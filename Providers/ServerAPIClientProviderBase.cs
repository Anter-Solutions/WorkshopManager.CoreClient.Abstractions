namespace WorkshopManager.CoreClient.Abstractions.Providers
{
    /// <summary>
    /// Provides HttpClient for Server API requests.
    /// </summary>
    public abstract class ServerAPIClientProviderBase
    {
        protected HttpClient HttpClient { get; init; }

        public ServerAPIClientProviderBase(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        /// <summary>
        /// Returns HttpClient for requests.
        /// </summary>
        /// <returns>HttpClient</returns>
        public abstract HttpClient GetClient();
    }
}
