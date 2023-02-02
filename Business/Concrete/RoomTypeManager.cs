using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Concrete;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs.RoomType;
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

        [ValidationAspect(typeof(RoomTypeValidator))]
        public IResult Add(RoomType roomType)
        {
            _roomTypeDal.Add(roomType);
            return new SuccessResult(Messages.RoomTypeAdded);
        }

        public IResult Delete(RoomType roomType)
        {
            _roomTypeDal.Delete(roomType);
            return new SuccessResult(Messages.RoomTypeDeleted);
        }

        public IDataResult<RoomType> Get(int id)
        {
            return new SuccessDataResult<RoomType>(_roomTypeDal.Get(r => r.Id == id), Messages.RoomTypeGeted);
        }

        public IDataResult<List<RoomType>> GetAll()
        {
            return new SuccessDataResult<List<RoomType>>(_roomTypeDal.GetAll(), Messages.RoomTypesListed);
        }

        public IDataResult<List<RoomTypeDetailDto>> GetRoomTypeDetailDtos()
        {
            return new SuccessDataResult<List<RoomTypeDetailDto>>(_roomTypeDal.GetRoomTypeDetailDtos(), Messages.RoomTypeDetailDtoListed);
        }

        [ValidationAspect(typeof(RoomTypeValidator))]
        public IResult Update(RoomType roomType)
        {
            _roomTypeDal.Update(roomType);
            return new SuccessResult(Messages.RoomTypeUpdated);
        }
    }
}
