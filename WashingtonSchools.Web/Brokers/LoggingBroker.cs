using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WashingtonSchools.Web.Brokers
{
    public class LoggingBroker : ILoggingBroker
    {
        private readonly ILogger logger;
        public LoggingBroker(ILogger logger) => this.logger = logger;
        public void Error(string message) => this.logger.LogError(message);
    }
}
