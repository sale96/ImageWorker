using Microsoft.Extensions.DependencyInjection;

namespace ImageWorker.Extensions
{
    /// <summary>
    /// Register IWorkerImageFactory
    /// to asp.net core dependency injection
    /// </summary>
    public static class ImageWorkerCore
    {
        public static IServiceCollection RegisterImageWorker(this IServiceCollection services)
        {
            services.AddTransient<IWorkerImageFactory, WorkerFactory>();
            return services;
        }
    }
}
