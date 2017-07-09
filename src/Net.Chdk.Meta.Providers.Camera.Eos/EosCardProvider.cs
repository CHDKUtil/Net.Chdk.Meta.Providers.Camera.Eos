using Net.Chdk.Meta.Model.Camera.Eos;

namespace Net.Chdk.Meta.Providers.Camera.Eos
{
    public abstract class EosCardProvider : CardProvider<EosCardData>, IEosCardProvider
    {
        protected override string GetCardSubtype(uint modelId)
        {
            return null;
        }
    }
}
