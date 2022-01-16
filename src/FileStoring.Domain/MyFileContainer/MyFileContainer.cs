using System;
using Volo.Abp.BlobStoring;

namespace FileStoring
{
    [BlobContainerName("my-file-container")]
    public class MyFileContainer
    {
          public Guid Id { get; set; }
          public string Name { get; set; }
          
          
          
          
    }
}