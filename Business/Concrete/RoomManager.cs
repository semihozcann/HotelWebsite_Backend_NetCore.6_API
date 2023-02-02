using Business.Abstract;
using Core.DataAccess.Concrete;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
    public class RoomManager : IRoomService
    {
        IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public IResult Add(Room room)
        {
            _roomDal.Add(room);
            return new SuccessResult("Oda Eklendi");
        }

        public IResult Delete(Room room)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Room> Get()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Room>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
