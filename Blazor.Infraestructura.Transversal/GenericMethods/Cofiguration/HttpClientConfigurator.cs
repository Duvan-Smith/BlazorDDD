using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Net.Http;

namespace Blazor.Infraestructura.Transversal.GenericMethods.Cofiguration
{
    public static class HttpClientConfigurator
    {
        public static void ConfigureHttpClientService(this IServiceCollection services, HttpClientSettings settings)
        {
            services.TryAddTransient<HttpClient>();
            services.AddHttpClient<HttpGenericBaseClient>();
            services.Configure<HttpClientSettings>(o => o.CopyFrom(settings));
            services.TryAddTransient<IHttpGenericBaseClient, HttpGenericBaseClient>();
        }
    }
}