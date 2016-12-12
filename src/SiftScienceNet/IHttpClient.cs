namespace SiftScienceNet
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public interface IHttpClient
    {
        void SetAccept(string contentType);
        Task<HttpResponseMessage> GetAsync(string requestUri);
        Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content);
    }
}
