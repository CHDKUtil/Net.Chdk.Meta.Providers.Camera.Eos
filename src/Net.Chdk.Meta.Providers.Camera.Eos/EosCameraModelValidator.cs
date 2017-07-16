using Microsoft.Extensions.Logging;

namespace Net.Chdk.Meta.Providers.Camera.Eos
{
    sealed class EosCameraModelValidator : CameraModelValidator
    {
        public EosCameraModelValidator(ILogger<EosCameraModelValidator> logger)
            : base(logger)
        {
        }
    }
}
