using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace FileStoring
{
    public interface IFileAppService : IApplicationService
    {
        Task SaveBlobAsync(SaveBlobInputDto input);

        Task<BlobDto> GetBlobAsync(GetBlobRequestDto input);
    }
    
    public class BlobDto
    {
        public byte[] Content { get; set; }

        public string Name { get; set; }
    }
    public class GetBlobRequestDto
    {
        [Required]
        public string Name { get; set; }
    }
    public class SaveBlobInputDto
    {
        public byte[] Content { get; set; }

        [Required]
        public string Name { get; set; }
    }
}