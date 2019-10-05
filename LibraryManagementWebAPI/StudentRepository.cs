using LibraryManagementWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebAPI
{
    public class StudentRepository: IStudentRepository
    {
        private LibraryContext _context;

        public StudentRepository(LibraryContext context)
        {
            _context = context;
        }

        public List<Student> GetStudentInfo(int Id)
        {
            return _context.Students.Where(x => x.Id == Id).FirstOrDefault();
        }
    }
}
