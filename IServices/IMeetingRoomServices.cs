using DomainDTO.EFModels;
using DomainDTO.OutPutModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    public interface IMeetingRoomServices
    {
        int MeetingRoomNewAdd(MeetingRoomNew roomnew);
        int ReservationMeetingRoomAdd(ReservationMeetingRoom reserva);
        List<MeetingRoomOutPut> GetMeetingRoom();
    }
}
