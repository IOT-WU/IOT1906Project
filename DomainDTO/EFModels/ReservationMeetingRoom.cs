using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class ReservationMeetingRoom
    {
        [Key]
        public int Reservation_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 会议室
        /// </summary>
        public int Reservation_MeetingRoom { get; set; }
        /// <summary>
        /// 座位
        /// </summary>
        public string Reservation_Seat { get; set; }
        /// <summary>
        /// 使用部门
        /// </summary>
        public string Reservation_UseDepartment { get; set; }
        /// <summary>
        /// 使用人
        /// </summary>
        public string Reservation_Users { get; set; }
        /// <summary>
        /// 事由
        /// </summary>
        public string Reservation_Reason { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string Reservation_BeginTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string Reservation_OverTime { get; set; }
    }
}
