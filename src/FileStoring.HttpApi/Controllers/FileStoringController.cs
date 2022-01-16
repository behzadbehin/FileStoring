using FileStoring.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FileStoring.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FileStoringController : AbpControllerBase
    {
        protected FileStoringController()
        {
            LocalizationResource = typeof(FileStoringResource);
        }
    }
}