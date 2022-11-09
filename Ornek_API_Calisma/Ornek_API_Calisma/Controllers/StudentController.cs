using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ornek_API_Calisma.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public List<Ogrenci> Get()
        {
            return studentService.ListOfStudents();
        }
        [HttpPost]
        public int Post([FromBody] Ogrenci ogr) //FromBody kullanmamızın sebebi direk verdiğimiz route'ta controller'ın içindeki bütün metodlara erişebilmek. Aksi takdirde bütün yollara route vermek gerekir
        {
            return studentService.AddStudent(ogr);
        }
        [HttpPut]
        public int Put([FromBody] Ogrenci ogr)
        {
            return studentService.UpdateStudent(ogr);
        }
        [HttpDelete]
        public int Delete(int id)
        {
            var result = studentService.getByID(id);
            return studentService.DeleteStudent(result);
        }
        [HttpGet("{id}")]
        public Ogrenci GetByID(int id)
        {
            return studentService.getByID(id);
        }
    }
}
