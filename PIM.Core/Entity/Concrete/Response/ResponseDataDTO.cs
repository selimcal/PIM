using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Core.Entity.Concrete.Response
{
    public class ResponseDataDTO<T> : ResponseDTO
    {
        public ResponseDataDTO()
        {

        }
        public ResponseDataDTO(bool success) : base(success)
        {

        }
        public ResponseDataDTO(bool success, string message) : base(success, message)
        {

        }
        public ResponseDataDTO(bool success, string message, T data) : base(success, message)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}
