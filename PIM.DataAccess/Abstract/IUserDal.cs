﻿using PIM.Core.DataAccess.Abstract;
using PIM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.DataAccess.Abstract
{
    public interface IUserDal : IRepository<User>
    {
    }
}
