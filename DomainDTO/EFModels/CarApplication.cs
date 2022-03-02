using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 用车申请表
    /// </summary>
    public class CarApplication
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string CarUse_Proposer { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string CarUse_Demt { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string CarUse_ApplyDate { get; set; }
        /// <summary>
        /// 星期
        /// </summary>
        public string CarUse_Week { get; set; }
        /// <summary>
        /// 出发地点
        /// </summary>
        public string CarUse_StartSite { get; set; }
        /// <summary>
        /// 目标地点
        /// </summary>
        public string CarUse_EndSite { get; set; }
        /// <summary>
        /// 出发时间
        /// </summary>
        public DateTime CarUse_StartTime { get; set; }
        /// <summary>
        /// 返回时间
        /// </summary>
        public DateTime CarUse_BackTime { get; set; }
        /// <summary>
        /// 乘车人数
        /// </summary>
        public string CarUse_PeopleNum { get; set; }
        /// <summary>
        /// 随行人员
        /// </summary>
        public string CarUse_AccPeople { get; set; }
        /// <summary>
        /// 事由
        /// </summary>
        public string CarUse_Cause { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string CarUse_CarID { get; set; }
        /// <summary>
        /// 出差详细信息-出发时间
        /// </summary>
        public DateTime CarUseStartTime { get; set; }
        /// <summary>
        /// 途径
        /// </summary>
        public string CarUse_Approach { get; set; }
        /// <summary>
        /// 出发表盘公里数
        /// </summary>
        public string CarUse_StartKM { get; set; }
        /// <summary>
        /// 结束表盘公里数
        /// </summary>
        public string CarUse_EndKM { get; set; }
        /// <summary>
        /// 实际公里数
        /// </summary>
        public string CarUse_RealKM { get; set; }
        /// <summary>
        /// 驾驶员
        /// </summary>
        public string CarUse_Driver { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string CarUse_Remark { get; set; }
    }
}
