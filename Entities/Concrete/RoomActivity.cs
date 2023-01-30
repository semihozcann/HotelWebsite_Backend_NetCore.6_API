using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RoomActivity : IEntity
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public int NumberOfRoom { get; set; }
        public DateTime Date { get; set; }

        public List<RoomType> RoomTypes { get; set; }


    }
}
