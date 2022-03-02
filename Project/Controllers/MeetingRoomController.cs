using DomainDTO.EFModels;
using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    /// <summary>
    /// 会议室控制器
    /// </summary>
    [ApiController]
    public class MeetingRoomController : ControllerBase
    {
        private readonly IMeetingRoomServices meeting;
        public MeetingRoomController(IMeetingRoomServices meeting)
        {
            this.meeting = meeting;
        }
        /// <summary>
        /// 会议室新增
        /// </summary>
        /// <param name="roomnew"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/MeetingRoomNewAdd")]
        public IActionResult MeetingRoomNewAdd(MeetingRoomNew roomnew)
        {
            return Ok(meeting.MeetingRoomNewAdd(roomnew));
        }
        /// <summary>
        /// 会议室预定
        /// </summary>
        /// <param name="roomnew"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/ReservationMeetingRoomAdd")]
        public IActionResult ReservationMeetingRoomAdd(ReservationMeetingRoom reserva)
        {
            return Ok(meeting.ReservationMeetingRoomAdd(reserva));
        }
        /// <summary>
        /// 下拉框
        /// </summary>
        /// <param name="reserva"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetMeetingRoom")]
        public IActionResult GetMeetingRoom(int id)
        {
            return Ok(meeting.GetMeetingRoom(id));
        }
    }
}
