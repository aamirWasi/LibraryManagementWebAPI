using LibraryManagementWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebAPI
{
     public  interface IStudentRepository
     {
         List<Student> GetStudentInfo(int Id);
     }
}
