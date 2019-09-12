using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WashingtonSchools.Web.Brokers
{
    public interface ILoggingBroker
    {
        void Error(string message);
    }
}
