

using Microsoft.Azure.WebJobs;

namespace Microsoft.Extensions.DependencyInjection
{
        public static class WebJobsServiceCollectionExtensions
        {
        public static IWebJobsBuilder AddWebJobs(this IServiceCollection services)
        {
            return new WebJobsBuilder();
        }

        private class WebJobsBuilder : IWebJobsBuilder
        {
            public IServiceCollection Services => throw new System.NotImplementedException();
        }
    }
}