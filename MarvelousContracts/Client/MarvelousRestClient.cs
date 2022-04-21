using Marvelous.Contracts.Enums;
using RestSharp;

namespace Marvelous.Contracts.Client;

public class MarvelousRestClient : RestClient, IRestClient
{
    public void AddMicroservice(Microservice service) =>
        this.AddDefaultHeader(nameof(Microservice), service.ToString());

    public Task<RestResponse<T>> ExecuteAsync<T>(RestRequest request, CancellationToken cancellationToken = default) =>
        RestClientExtensions.ExecuteAsync<T>(this, request, cancellationToken);
}
