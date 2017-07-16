using Microsoft.Extensions.Logging;

namespace Net.Chdk.Meta.Providers.Camera.Eos
{
    sealed class EosCameraValidator : CameraValidator
    {
        public EosCameraValidator(ILogger<EosCameraValidator> logger)
            : base(logger)
        {
        }
    }
}
