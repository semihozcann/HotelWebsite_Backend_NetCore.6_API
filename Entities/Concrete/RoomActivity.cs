using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RoomActivity : BaseEntity, IEntity
    {
        public int RoomTypeId { get; set; }
        public int NumberOfRoom { get; set; }
        public DateTime Date { get; set; }

        public virtual RoomType RoomType { get; set; }


    }
}
