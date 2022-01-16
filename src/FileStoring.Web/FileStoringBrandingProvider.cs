using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace FileStoring.Web
{
    [Dependency(ReplaceServices = true)]
    public class FileStoringBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FileStoring";
    }
}
