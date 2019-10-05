using LibraryManagementWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebAPI
{
    public interface IStudentService
    {
        List<Student> StudentProfile(int Id);
    }
}
