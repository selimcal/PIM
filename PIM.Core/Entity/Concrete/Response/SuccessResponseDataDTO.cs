using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Core.Entity.Concrete.Response
{
    public class SuccessResponseDataDTO<T> : ResponseDataDTO<T>
    {
        public SuccessResponseDataDTO(T data) : base(success: true)
        {
            Data = data;
        }

        public SuccessResponseDataDTO(T data, string message) : base(success: true, message: message)
        {
            Data = data;
        }
    }
}
