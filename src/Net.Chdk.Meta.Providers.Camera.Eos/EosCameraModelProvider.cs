using Net.Chdk.Meta.Model.Camera.Eos;
using Net.Chdk.Meta.Model.CameraList;
using Net.Chdk.Meta.Model.CameraTree;
using System.Collections.Generic;

namespace Net.Chdk.Meta.Providers.Camera.Eos
{
    sealed class EosCameraModelProvider : CameraModelProvider<EosCameraModelData>, IEosCameraModelProvider
    {
        private IVersionProvider VersionProvider { get; }

        public EosCameraModelProvider(IVersionProvider versionProvider, ICameraModelValidator modelValidator)
            : base(modelValidator)
        {
            VersionProvider = versionProvider;
        }

        public override EosCameraModelData GetModel(string platform, string[] names, ListPlatformData list, TreePlatformData tree, string productName)
        {
            var model = base.GetModel(platform, names, list, tree, productName);
            model.Versions = GetVersions(platform, list, tree);
            return model;
        }

        private IDictionary<string, VersionData> GetVersions(string platform, ListPlatformData list, TreePlatformData tree)
        {
            var versions = new SortedDictionary<string, VersionData>();
            foreach (var kvp in tree.Revisions)
            {
                var version = VersionProvider.GetVersion(kvp.Key, kvp.Value, list, tree);
                if (version != null)
                {
                    var versionKey = GetVersionKey(kvp.Key);
                    versions.Add(versionKey, version);
                }
            }
            return versions;
        }

        private static string GetVersionKey(string version)
        {
            return $"{version[0]}.{version[1]}.{version[2]}";
        }
    }
}
