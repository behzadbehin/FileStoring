

using System;
using AutoMapper;
using Volo.Abp.Guids;

namespace FileStoring.Employees
{
    public class EmployeeCreateMap : Profile
    {
        public EmployeeCreateMap()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
        }
    }

}