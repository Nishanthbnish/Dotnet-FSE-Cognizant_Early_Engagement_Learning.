using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomExceptionFilter.Models
{
    public class ExceptionFilter : IExceptionFilter
    {
        private readonly ILoggerManager _logger;

        public ExceptionFilter()
        {
            _logger = new LoggerManager();
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogInformation(context.Exception.ToString());
        }
    }
}
