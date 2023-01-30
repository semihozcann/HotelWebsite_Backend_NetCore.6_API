using Core.Entities.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Booking : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookingItemId { get; set; }
        public int PaymentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public User user { get; set; }
        public List<BookingItem> bookingItems { get; set; }


    }
}
