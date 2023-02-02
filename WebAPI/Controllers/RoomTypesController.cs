using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs.RoomType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypesController : ControllerBase
    {
        IRoomTypeService _roomTypeService;

        public RoomTypesController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        [HttpPost("add")]

        public IActionResult Add(RoomType roomType)
        {
            var result =_roomTypeService.Add(roomType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getroomtypedetails")]
        public List<RoomTypeDetailDto> GetRoomTypeDetailDtos()
        {
            var result = _roomTypeService.GetRoomTypeDetailDtos();
            return result.Data;
        }
    }
}
