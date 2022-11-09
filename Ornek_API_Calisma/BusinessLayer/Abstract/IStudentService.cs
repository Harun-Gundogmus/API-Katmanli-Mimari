using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStudentService
    {
        int AddStudent(Ogrenci ogr);
        int UpdateStudent(Ogrenci ogr);
        int DeleteStudent(Ogrenci ogr);
        Ogrenci getByID(int id);
        List<Ogrenci> ListOfStudents();
    }
}
