using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs.RoomType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRoomTypeDal : EfEntityRepositoryBase<RoomType, HotelDbContext>, IRoomTypeDal
    {
        public List<RoomTypeDetailDto> GetRoomTypeDetailDtos()
        {
            using (HotelDbContext context = new HotelDbContext())
            {
                var result = from r in context.RoomTypes
                             select new RoomTypeDetailDto
                             {
                                 Name = r.Name,
                                 ImageUrl = r.ImageUrl,
                                 NumberOfPeople = r.NumberOfPeople
                             };
                return result.ToList();
            }
        }
    }
}
