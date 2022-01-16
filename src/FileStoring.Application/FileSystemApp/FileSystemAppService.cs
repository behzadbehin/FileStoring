using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.BlobStoring;
using Volo.Abp.BlobStoring.Database;
using Volo.Abp.Domain.Repositories;

namespace FileStoring.FileSystem
{
    public class
    FileSystemAppService
    : ApplicationService, IFileSystemAppService
    {
        private IBlobContainer _blobContainer;
        private readonly IRepository<DatabaseBlobContainer,Guid> _repositoryContainer;

        private readonly IBlobContainerFactory _blobContainerFactory;

        public FileSystemAppService(
            IBlobContainer blobContainer,
            IBlobContainerFactory blobContainerFactory,
            IRepository<DatabaseBlobContainer, Guid> repositoryContainer
        )
        {
            _blobContainer = blobContainer;
            _blobContainerFactory = blobContainerFactory;
            _repositoryContainer = repositoryContainer;
        }

        public async Task<Guid> SaveBlobAsync(Guid? enetityId, SaveFilesInputDto input)
        {
            enetityId = enetityId ?? Guid.NewGuid();
            _blobContainer = _blobContainerFactory.Create(enetityId.ToString());
            
            try
            {
                foreach (var item in input.BlobStorings)
                {
                    await _blobContainer
                        .SaveAsync(item.FileName, item.Content, true);
                }
                return enetityId.Value;
            }
            catch
            {
                return Guid.Empty;
            }
        }
    }
}
