using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BookingItem : BaseEntity, IEntity
    {
        public int RoomTypeId { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public bool IsActive { get; set; }

 
        public virtual RoomType roomType { get; set; }


    }
}
