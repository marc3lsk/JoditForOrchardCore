using OrchardCore.ResourceManagement;

namespace JoditForOrchardCore
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineStyle("jodit")
                .SetUrl("~/JoditForOrchardCore/jodit/jodit.min.css", "~/JoditForOrchardCore/jodit/jodit.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/jodit/3.3.23/jodit.min.css")
                .SetVersion("3.3.23");

            manifest
                .DefineScript("jodit")
                .SetUrl("~/JoditForOrchardCore/jodit/jodit.min.js", "~/JoditForOrchardCore/jodit/jodit.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/jodit/3.3.23/jodit.min.js")
                .SetVersion("3.3.23");
        }
    }
}
