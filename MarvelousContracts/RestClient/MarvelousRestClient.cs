using Marvelous.Contracts.Enums;
using RestSharp;

namespace Auth.BusinessLayer.Helpers;

public class MarvelousRestClient : RestClient, IRestClient
{
    public RestClient AddMicroservice(Microservice service) =>
        this.AddDefaultHeader(nameof(Microservice), service.ToString());

    public Task<RestResponse<T>> ExecuteAsync<T>(RestRequest request, CancellationToken cancellationToken = default) =>
        RestClientExtensions.ExecuteAsync<T>(this, request, cancellationToken);
}
