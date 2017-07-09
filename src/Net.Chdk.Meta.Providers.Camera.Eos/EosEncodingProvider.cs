using Net.Chdk.Meta.Model.Camera;

namespace Net.Chdk.Meta.Providers.Camera.Eos
{
    sealed class EosEncodingProvider : EncodingProvider
    {
        protected override EncodingData[] GetEncodings()
        {
            return new[]
            {
                EmptyEncoding
            };
        }
    }
}
