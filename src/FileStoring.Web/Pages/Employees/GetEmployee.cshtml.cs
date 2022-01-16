using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;
using FileStoring.Employees;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace FileStoring.Web.Pages.Employees
{
    public class GetEmployees : AbpPageModel
    {
        // [BindProperty]
        // public UploadFileDto UploadFileDto { get; set; }

        // private readonly IFileAppService _fileAppService;
        //[BindProperty]
        //public SaveEmployeeDto SaveEmployeeDto { get; set; }
        
        private readonly IEmployeeAppService _employeeService;
        //public bool Saved { get; set; } = false;

        public GetEmployees(IEmployeeAppService employeeAppService)
        {
            _employeeService = employeeAppService;
        }

        public void OnGet()
        {

        }

        
    }

    
}

