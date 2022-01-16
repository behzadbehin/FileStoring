using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FileStoring.FileSystem
{
    public interface IFileSystemAppService : IApplicationService
    {
        Task<Guid> SaveBlobAsync(Guid? entityId,SaveFilesInputDto input);
    }

    public class SaveFilesInputDto : EntityDto<Guid>
    {
        [Required]
        public List<FileDto> BlobStorings { get; set; }
    }

    public class FileDto
    {
        public byte[] Content { get; set; }
        public string FileName { get; set; }
    }
    public class SaveFilesOutputDto: EntityDto<Guid>
    {
        public string ContainerName { get; set; }        
    }
}
