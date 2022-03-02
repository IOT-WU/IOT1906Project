using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class MeetingRoomNew
    {
        [Key]
        public int MeetingRoom_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 会议室名称
        /// </summary>
        public string MeetingRoom_Name { get; set; }
        /// <summary>
        /// 座位
        /// </summary>
        public string MeetingRoom_Seat { get; set; }
        /// <summary>
        /// 楼层
        /// </summary>
        public string MeetingRoom_Floor { get; set; }
        /// <summary>
        /// 可容纳人数
        /// </summary>
        public string MeetingRoom_Capacity { get; set; }
        /// <summary>
        /// 空调
        /// </summary>
        public string MeetingRoom_OrAirConditioner { get; set; }
        /// <summary>
        /// 投影仪
        /// </summary>
        public string MeetingRoom_OrProjector { get; set; }
        /// <summary>
        /// 白板
        /// </summary>
        public string MeetingRoom_OrWhiteboard { get; set; }
        /// <summary>
        /// 网络
        /// </summary>
        public string MeetingRoom_OrNetwork { get; set; }
        /// <summary>
        /// 网络范围
        /// </summary>
        public string MeetingRoom_OrNetworkRange { get; set; }
        /// <summary>
        /// 饮水机
        /// </summary>
        public string MeetingRoom_OrWaterDispenser { get; set; }
        /// <summary>
        /// 管理员
        /// </summary>
        public string MeetingRoom_Administrator { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
        public string MeetingRoom_Image { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string MeetingRoom_Note { get; set; }
    }
}
