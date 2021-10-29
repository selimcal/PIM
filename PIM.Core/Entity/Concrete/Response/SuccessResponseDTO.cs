using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Core.Entity.Concrete.Response
{
    public class SuccessResponseDTO : ResponseDTO
    {
        public SuccessResponseDTO() : base(success: true)
        {

        }

        public SuccessResponseDTO(string message) : base(success: true, message: message)
        {

        }
    }
}
