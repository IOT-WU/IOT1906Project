using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class Reception
    {
        /// <summary>
        /// 接待申请表
        /// </summary>
        [Key]
        public int Reception_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Reception_Applicant { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Reception_Department { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public string Reception_ApplyTime { get; set; }
        /// <summary>
        /// 来访客人单位
        /// </summary>
        public string Reception_GuestUnit { get; set; }
        /// <summary>
        /// 主要客人姓名·职务
        /// </summary>
        public string Reception_GuestName { get; set; }
        /// <summary>
        /// 停留开始时间
        /// </summary>
        public string Reception_BeginResidenceTime { get; set; }
        /// <summary>
        /// 停留结束时间
        /// </summary>
        public string Reception_OverResidenceTime { get; set; }
        /// <summary>
        /// 接待人
        /// </summary>
        public string Reception_Unawares { get; set; }
        /// <summary>
        /// 人数
        /// </summary>
        public string Reception_Number { get; set; }
        /// <summary>
        /// 是否需要准备资料
        /// </summary>
        public string Reception_OrData { get; set; }
        /// <summary>
        /// 往来航班号
        /// </summary>
        public string Reception_Flight { get; set; }
        /// <summary>
        /// 是否需要物品
        /// </summary>
        public string Reception_OrItems { get; set; }
        /// <summary>
        /// 来访事由
        /// </summary>
        public string Reception_Reason { get; set; }
        /// <summary>
        /// 其他要求
        /// </summary>
        public string Reception_OtherRequirements { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Reception_Note { get; set; }
    }
}
