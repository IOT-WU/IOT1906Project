using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 请假申请表
    /// </summary>
    public class Leave : BaseModels
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 请假类型
        /// </summary>
        public int Leave_LeaveType { get; set; }
        /// <summary>
        /// 请假开始时间
        /// </summary>
        public DateTime Leave_StartDate { get; set; }
        /// <summary>
        /// 请假结束时间
        /// </summary>
        public DateTime Leave_EndDate { get; set; }
        /// <summary>
        /// 请假天数
        /// </summary>
        public int Leave_Day { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Leave_Proposer { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime Leave_Time { get; set; }
        /// <summary>
        /// 请假原因
        /// </summary>
        public string Leave_Reason { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string Leave_AffixName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Leave_Remark { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public string Leave_Position { get; set; }
    }
}
