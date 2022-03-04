using DomainDTO.EFModels;
using DomainDTO.OutPutModels;
using IRepository;
using IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MeetingRoomServices : IMeetingRoomServices
    {
        private readonly IRepositoryDB<MeetingRoomNew> repository;
        private readonly IRepositoryDB<ReservationMeetingRoom> repository1;
        public MeetingRoomServices(IRepositoryDB<MeetingRoomNew> repository, IRepositoryDB<ReservationMeetingRoom> repository1)
        {
            this.repository = repository;
            this.repository1 = repository1;
        }

        public int MeetingRoomNewAdd(MeetingRoomNew roomnew)
        {
            return repository.ExecuteAdd(roomnew);
        }

        public int ReservationMeetingRoomAdd(ReservationMeetingRoom reserva)
        {
            return repository1.ExecuteAdd(reserva);
        }

        public List<MeetingRoomOutPut> GetMeetingRoom()
        {
            var list = (from s in repository.QueryList(x => x.MeetingRoom_Id.Equals(x.MeetingRoom_Id))
                        select new MeetingRoomOutPut
                        {
                            MeetingRoomId = s.MeetingRoom_Id,
                            MeetingRoomName = s.MeetingRoom_Name
                        }).ToList();
            return list;
        }
    }
}
