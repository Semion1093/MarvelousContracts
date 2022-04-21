using Marvelous.Contracts.Enums;
using RestSharp;
using RestSharp.Authenticators;

namespace Marvelous.Contracts.Client;

public interface IRestClient
{
    public IAuthenticator? Authenticator { get; set; }
    public void AddMicroservice(Microservice service);
    public Task<RestResponse<T>> ExecuteAsync<T>(RestRequest request, CancellationToken cancellationToken = default);
    public Task<RestResponse> ExecuteAsync(RestRequest request, CancellationToken cancellationToken = default);

}
