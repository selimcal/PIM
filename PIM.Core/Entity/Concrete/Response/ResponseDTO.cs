using PIM.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Core.Entity.Concrete.Response
{
    public class ResponseDTO : IDto
    {
        public ResponseDTO()
        {
        }

        public ResponseDTO(bool success)
        {
            Success = success;
        }

        public ResponseDTO(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
