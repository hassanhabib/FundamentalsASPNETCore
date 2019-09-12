using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WashingtonSchools.Web.Models;

namespace WashingtonSchools.Web.Services
{
    public interface IStudentsService
    {
        Task RegisterStudentAsync(Student student);
    }
}
