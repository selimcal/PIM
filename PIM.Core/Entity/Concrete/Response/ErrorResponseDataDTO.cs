using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Core.Entity.Concrete.Response
{
    public class ErrorResponseDataDTO<T> : ResponseDataDTO<T>
    {
        public ErrorResponseDataDTO(T data) : base(success: false)
        {
            Data = data;
        }

        public ErrorResponseDataDTO(T data, string message) : base(success: false, message: message)
        {
            Data = data;
        }
    }
}
