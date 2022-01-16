using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FileStoring.Employees
{
    public interface IEmployeeAppService : ICrudAppService<EmployeeDto,Guid>
    {
        Task SaveEmployeeAsync(EmployeeDto input);
    }
     
     public class EmployeeDto : EntityDto<Guid>
    {
        [Required]
        public string Name { get; set; }
        public byte[] Content { get; set; }
        public string FileName { get; set; }
        
        
        
    }

    

}