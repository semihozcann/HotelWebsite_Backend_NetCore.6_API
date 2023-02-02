using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RoomType : BaseEntity, IEntity
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string NumberOfPeople { get; set; }

    }
}
