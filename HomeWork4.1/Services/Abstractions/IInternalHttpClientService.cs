using System.Net.Http;
using System.Threading.Tasks;

namespace HomeWork4._1.Services.Abstractions;

public interface IInternalHttpClientService
{
    Task<TResponse> SendAsync<TResponse, TRequest>(string url, HttpMethod method, TRequest content = null)
        where TRequest : class;
}