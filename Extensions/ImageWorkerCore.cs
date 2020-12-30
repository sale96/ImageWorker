using Microsoft.Extensions.DependencyInjection;

namespace ImageWorker.Extensions
{
    /// <summary>
    /// Register IWorkerImageFactory
    /// to asp.net core dependency injection
    /// </summary>
    public static class ImageWorkerCore
    {
        public static IServiceCollection RegisterImageFactory(this IServiceCollection services)
        {
            services.AddTransient<IFactoryImage, FactoryImage>();
            return services;
        }
    }
}
