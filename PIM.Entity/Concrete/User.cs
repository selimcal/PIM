using System;
using PIM.Core.Entity.Concrete;

namespace PIM.Entity.Concrete
{
    public class User : BaseEntity<Guid>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
