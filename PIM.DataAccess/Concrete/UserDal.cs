using PIM.Core.DataAccess.Concrete.EntityFramework;
using PIM.DataAccess.Abstract;
using PIM.DataAccess.Concrete.Context;
using PIM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.DataAccess.Concrete
{
    public class UserDal : EfBaseRepository<User, ProjectContext>, IUserDal
    {
    }
}
