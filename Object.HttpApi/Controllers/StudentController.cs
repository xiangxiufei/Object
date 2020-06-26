using Microsoft.AspNetCore.Mvc;
using Object.Application.Contracts.School;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Object.HttpApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : AbpController
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpPost]
        public async Task<string> Insert([FromForm] StudentDto student)
        {
            return await studentService.Insert(student);
        }

        [HttpPost]
        public async Task<string> Update([FromForm] StudentDto student)
        {
            return await studentService.Update(student);
        }

        [HttpPost]
        public async Task<string> Delete(int id)
        {
            return await studentService.Delete(id);
        }

        [HttpGet]
        public async Task<string> Select(int id)
        {
            return await studentService.GetEntity(id);
        }
    }
}