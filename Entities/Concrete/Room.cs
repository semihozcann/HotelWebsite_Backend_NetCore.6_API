using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Room : IEntity
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public int ImageId { get; set; }
        public decimal DailyPrice { get; set; }
        public short Discount { get; set; }
        public string Description { get; set; }

        public RoomType roomType { get; set; }
        public List<Image> images { get; set; }

    }
}
