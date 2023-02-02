using Business.Abstract;
using Business.Constants;
using Core.DataAccess.Concrete;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoomTypeManager : IRoomTypeService
    {

        IRoomTypeDal _roomTypeDal;

        public RoomTypeManager(IRoomTypeDal roomTypeDal)
        {
            _roomTypeDal = roomTypeDal;
        }


        public IResult Add(RoomType roomType)
        {
            _roomTypeDal.Add(roomType);
            return new SuccessResult(Messages.RoomTypeAdded);
        }

        public IResult Delete(RoomType roomType)
        {
            throw new NotImplementedException();
        }

        public IDataResult<RoomType> Get()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RoomType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(RoomType roomType)
        {
            throw new NotImplementedException();
        }
    }
}
