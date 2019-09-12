using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WashingtonSchools.Web.Models;

namespace WashingtonSchools.Web.Brokers
{
    public interface IStorageBroker
    {
        Task AddStudentAsync(Student student);
    }
}
