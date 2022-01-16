using System;
using System.Collections.Generic;
using System.Text;
using FileStoring.Localization;
using Volo.Abp.Application.Services;

namespace FileStoring
{
    /* Inherit your application services from this class.
     */
    public abstract class FileStoringAppService : ApplicationService
    {
        protected FileStoringAppService()
        {
            LocalizationResource = typeof(FileStoringResource);
        }
    }
}
