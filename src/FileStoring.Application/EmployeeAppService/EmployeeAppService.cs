using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.BlobStoring;
using Volo.Abp.Domain.Repositories;
using System.Linq;

namespace FileStoring.Employees
{
    public class EmployeeAppService : 
    CrudAppService<Employee,EmployeeDto,Guid>, IEmployeeAppService
    {
        private readonly IRepository<Employee,Guid> _repository;
        //private readonly IBlobContainer<Employee> _fileContainerEmployee;
        private IBlobContainer _fileContainer;
        private readonly IBlobContainerFactory _blobFactory;
        public EmployeeAppService(IRepository<Employee, Guid> repository,IBlobContainerFactory blobContainerFactory)
             : base (repository)
        {
            _repository=repository;
            // _fileContainer = blobContainerFactory.Create("t");
            _blobFactory = blobContainerFactory;
        }
        public async Task SaveEmployeeAsync(EmployeeDto input) 
        {
           var result =  await base.CreateAsync(input);

            if(result!=null)
            {
                _fileContainer = _blobFactory.Create(result.Id.ToString());
                // await _fileContainerEmployee.SaveAsync(input.FileName, input.Content, true);
                await _fileContainer.SaveAsync(input.FileName, input.Content, true);
            }
            
        }
        // public async Task<List<String>> GetBlobAsync(GetBlobRequestDto input)
        // {
        //     var Employees= _repository.GetListAsync().GetAwaiter().GetResult();
        //     if(!Employees.Any())
        //         return null;

        //     var query = from employees in Repository.GetListAsync().GetAwaiter().GetResult()
        //                     join employeeFiles in _fileContainer
        //                     select employees;




        //     var blob = await _fileContainer.GetAllBytesAsync(input.Name);
        //     return null;
        //     // return new BlobDto
        //     // {
        //     //     Name = input.Name,
        //     //     Content = blob
        //     // };
        // }
    }
}