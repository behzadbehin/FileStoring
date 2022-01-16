using System;
using Microsoft.AspNetCore.Http;
using Volo.Abp.BlobStoring;
using Volo.Abp.Domain.Entities;

namespace FileStoring.Employees
{
    [BlobContainerName("Employee")]
    public class Employee : Entity<Guid>
    {
        public Employee()
        {
            Id = Guid.NewGuid();
        }
        public string Name { get; set; }
        public string Department { get; set; }
        // public IFormFile EmployeeFile { get; set; }
        
        
    }
}