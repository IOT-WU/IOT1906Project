using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class ReceptionTripDetails
    {
        /// <summary>
        /// 接待申请行程详情表
        /// </summary>
        [Key]
        public int Trip_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string Trip_BeginTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string Trip_OverTime { get; set; }
        /// <summary>
        /// 行程
        /// </summary>
        public string Trip_Trip { get; set; }
        /// <summary>
        /// 陪同人员
        /// </summary>
        public string Trip_AccompanyingOfficials { get; set; }
        /// <summary>
        /// 是否用车
        /// </summary>
        public string Trip_OrCar { get; set; }
        /// <summary>
        /// 是否预定会议室
        /// </summary>
        public string Trip_OrReservationMeetingRoom { get; set; }
        /// <summary>
        /// 是否预定酒店
        /// </summary>
        public string Trip_OrReservationHotel { get; set; }
        /// <summary>
        /// 是否需要展厅
        /// </summary>
        public string Trip_OrHall { get; set; }
        /// <summary>
        /// 是否需要订餐
        /// </summary>
        public string Trip_OrMeal { get; set; }
        /// <summary>
        /// 参加公司哪些部门
        /// </summary>
        public string Trip_ParticipateDepartment { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Trip_Note { get; set; }
    }
}
