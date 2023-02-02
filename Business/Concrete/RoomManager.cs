using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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

        [ValidationAspect(typeof(RoomValidator))]
        public IResult Add(Room room)
        {
            _roomDal.Add(room);
            return new SuccessResult(Messages.RoomAdded);
        }

        public IResult Delete(Room room)
        {
            _roomDal.Delete(room);
            return new SuccessResult(Messages.RoomDeleted);
        }

        public IDataResult<Room> Get(int id)
        {
            return new SuccessDataResult<Room>(_roomDal.Get(r => r.Id == id), Messages.RoomGeted);
        }

        public IDataResult<List<Room>> GetAll()
        {
            return new SuccessDataResult<List<Room>>(_roomDal.GetAll(), Messages.RoomsListed);
        }

        public IResult Update(Room room)
        {
            _roomDal.Update(room);
            return new SuccessResult(Messages.RoomUpdated);
        }
    }
}
