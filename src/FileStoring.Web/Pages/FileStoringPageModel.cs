using FileStoring.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace FileStoring.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class FileStoringPageModel : AbpPageModel
    {
        protected FileStoringPageModel()
        {
            LocalizationResourceType = typeof(FileStoringResource);
        }
    }
}