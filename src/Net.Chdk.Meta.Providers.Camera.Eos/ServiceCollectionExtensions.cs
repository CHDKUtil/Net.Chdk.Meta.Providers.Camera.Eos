using Microsoft.Extensions.DependencyInjection;

namespace Net.Chdk.Meta.Providers.Camera.Eos
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEosBuildProvider(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddSingleton<IEosBuildProvider, EosBuildProvider>()
                .AddSingleton<IEosCameraProvider, EosCameraProvider>()
                .AddSingleton<IEosCameraModelProvider, EosCameraModelProvider>()
                .AddSingleton<IEncodingProvider, EosEncodingProvider>()
                .AddSingleton<IVersionProvider, VersionProvider>();
        }

        public static IServiceCollection AddEosCameraProviders(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddSingleton<ICameraPlatformProvider, EosCameraPlatformProvider>()
                .AddSingleton<ICameraValidator, EosCameraValidator>()
                .AddSingleton<ICameraModelValidator, EosCameraModelValidator>();
        }
    }
}
