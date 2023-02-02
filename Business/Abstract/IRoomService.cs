using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoomService
    {
        IDataResult<List<Room>> GetAll();
        IDataResult<Room> Get(int id);
        IResult Add(Room room);
        IResult Update(Room room);
        IResult Delete(Room room);
    }
}
