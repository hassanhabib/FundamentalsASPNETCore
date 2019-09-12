using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WashingtonSchools.Web.Brokers;
using WashingtonSchools.Web.Models;
using WashingtonSchools.Web.Models.Exceptions;

namespace WashingtonSchools.Web.Services
{
    public class StudentsService : IStudentsService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public StudentsService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public async Task RegisterStudentAsync(Student student)
        {
            try
            {
                await this.storageBroker.AddStudentAsync(student);
            }
            catch (DbUpdateException dbUpdateException)
            {
                this.loggingBroker.Error(dbUpdateException.Message);
                throw new StudentRegistrationFailedException();
            }
        }
    }
}
