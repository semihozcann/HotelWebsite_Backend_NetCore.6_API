using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RoomImage : BaseEntity, IEntity
    {
        public int RoomId { get; set; }
        public int ImageId { get; set; }

        public virtual Room room { get; set; }
        public virtual Image image { get; set; }


    }
}
