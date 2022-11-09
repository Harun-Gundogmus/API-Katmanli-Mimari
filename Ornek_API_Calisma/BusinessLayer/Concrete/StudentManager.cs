using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            this.studentDal = studentDal;
        }
        public int AddStudent(Ogrenci ogr)
        {
            return studentDal.Add(ogr);
        }

        public int DeleteStudent(Ogrenci ogr)
        {
            return studentDal.Delete(ogr);
        }

        public Ogrenci getByID(int id)
        {
            return studentDal.GetById(id);
        }

        public List<Ogrenci> ListOfStudents()
        {
            return studentDal.ListAll();
        }

        public int UpdateStudent(Ogrenci ogr)
        {
            return studentDal.Update(ogr);
        }
    }
}
