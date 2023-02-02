using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs.RoomType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoomTypeService
    {
        IDataResult<List<RoomType>> GetAll();
        IDataResult<RoomType> Get(int id);
        IResult Add(RoomType roomType);
        IResult Update(RoomType roomType);
        IResult Delete(RoomType roomType);
        IDataResult<List<RoomTypeDetailDto>> GetRoomTypeDetailDtos();
    }
}
