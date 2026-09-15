using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public sealed class Result
    {
        public bool EsExitoso { get;  }
        public string? Error { get;  }
        private Result(bool esExitoso, string? error)
        {
            EsExitoso = esExitoso;
            Error = error;
        }
        public static Result Exitoso()
        {
            return new Result(true, null);
        }
        public static Result Fallido(string error)
        {
            return new Result(false, error);
        }
    }
}
