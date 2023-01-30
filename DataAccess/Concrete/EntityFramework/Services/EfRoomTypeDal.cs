﻿using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Services
{
    public class EfRoomTypeDal : EfEntityRepositoryBase<RoomType, HotelDbContext>, IRoomTypeDal
    {
    }
}
