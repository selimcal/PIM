using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Core.Entity.Concrete.Response
{
    public class ErrorResponseDTO : ResponseDTO
    {
        public ErrorResponseDTO() : base(success: false)
        {

        }

        public ErrorResponseDTO(string message) : base(success: false, message: message)
        {

        }
    }
}
