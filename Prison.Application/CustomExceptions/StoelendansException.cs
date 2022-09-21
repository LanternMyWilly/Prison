using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison.Application.CustomExceptions
{
    public class PrisonException : Exception
    {
        public PrisonException() { }
        public PrisonException(string message) : base(message) { }
        public PrisonException(string message, Exception innerException) : base(message, innerException) { }
    }
}
