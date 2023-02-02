using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Room : BaseEntity, IEntity
    {
        public int RoomTypeId { get; set; }
        public decimal DailyPrice { get; set; }
        public short Discount { get; set; }
        public string Description { get; set; }

        public virtual RoomType roomType { get; set; }


    }
}
