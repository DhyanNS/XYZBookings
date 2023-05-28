using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XYZBookings.Models;
using XYZBookings.Repository;

namespace XYZBookings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoom _roomRepository;

        public RoomsController(IRoom roomRepository)
        {
            _roomRepository = roomRepository;
        }
        [HttpGet]
        public ActionResult GetRooms()
        {
            var rooms = _roomRepository.GetRooms();
            return Ok(rooms);
        }
        [HttpGet("{id}")]
        public ActionResult GetRoomById(int id)
        {
            var rooms = _roomRepository.GetRoomById(id);
            return Ok(rooms);
        }
        [HttpPut("{id}")]
        public ActionResult updateById(int id, Room room)
        {
            _roomRepository.updateById(id, room);
            return Ok();
        }
        [HttpPost]
        public ActionResult addRooms(Room rooms)
        {
            _roomRepository.addRooms(rooms);
            return Ok(rooms);
        }
        [HttpDelete("{id}")]
        public ActionResult deleteRooms(int id)
        {
            _roomRepository.removeRoom(id);
            return Ok();
        }
    }
}