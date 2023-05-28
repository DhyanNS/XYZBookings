using XYZBookings.Models;

namespace XYZBookings.Repository
{
   public interface IRoom
        {
    
            IEnumerable<Room> GetRooms();
            void addRooms(Room rooms);
            Room GetRoomById(int id);
            void removeRoom(int id);
            void updateById(int id, Room room);
        }
    }

