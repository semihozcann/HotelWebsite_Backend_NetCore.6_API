using Core.Entities.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Booking : BaseEntity, IEntity
    {
        public int PaymentTypeId { get; set; }
        public int UserId { get; set; }
        public int BookingItemId { get; set; }
        public bool IsActive { get; set; }


        public virtual PaymentType paymentType { get; set; }
        public virtual User user { get; set; }
        public virtual List<BookingItem> bookingItems { get; set; }


    }
}
