using Net.Chdk.Meta.Model.Camera.Eos;
using Net.Chdk.Meta.Model.CameraList;
using Net.Chdk.Meta.Model.CameraTree;

namespace Net.Chdk.Meta.Providers.Camera.Eos
{
    sealed class VersionProvider : IVersionProvider
    {
        public VersionData GetVersion(string version, TreeRevisionData treeRevision, ListPlatformData list, TreePlatformData tree)
        {
            var key = treeRevision.Source?.Revision ?? version;
            if (!list.Revisions.ContainsKey(key))
                return null;

            return GetVersion(version);
        }

        private static VersionData GetVersion(string version)
        {
            return new VersionData
            {
                Version = version
            };
        }
    }
}
