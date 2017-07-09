using Net.Chdk.Meta.Model.Camera.Eos;

namespace Net.Chdk.Meta.Providers.Camera.Eos
{
    sealed class EosCameraProvider : CameraProvider<EosCameraData, EosCameraModelData, EosCardData>, IEosCameraProvider
    {
        public EosCameraProvider(IEncodingProvider encodingProvider, IBootProvider bootProvider, IEosCardProvider cardProvider)
            : base(encodingProvider, bootProvider, cardProvider)
        {
        }
    }
}
