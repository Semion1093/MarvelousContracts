using Marvelous.Contracts.Enums;
using RestSharp;
using RestSharp.Authenticators;

namespace Auth.BusinessLayer.Helpers;

public interface IRestClient
{
    public IAuthenticator? Authenticator { get; set; }
    public RestClient AddMicroservice(Microservice service);
    public Task<RestResponse<T>> ExecuteAsync<T>(RestRequest request, CancellationToken cancellationToken = default);
}
}
