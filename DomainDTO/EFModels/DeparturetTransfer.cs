using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 离职交接表
    /// </summary>
    public class DeparturetTransfer
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Dt_Proposer { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Dt_Demt { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime Dt_ApplyDate { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public string Dt_Position { get; set; }
        /// <summary>
        /// 离职证明
        /// </summary>
        public string Dt_Certify { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string Dt_Files { get; set; }
        /// <summary>
        /// 交接人
        /// </summary>
        public string Dt_Heir { get; set; }
        /// <summary>
        /// 部门交接内容
        /// </summary>
        public string Dt_DemtContent { get; set; }
        /// <summary>
        /// 部门交接情况
        /// </summary>
        public string Dt_DemtCase { get; set; }
        /// <summary>
        /// 财务部交接内容
        /// </summary>
        public string Dt_FinanceContent { get; set; }
        /// <summary>
        /// 财务部交接情况
        /// </summary>
        public string Dt_FinanceCase { get; set; }
        /// <summary>
        /// 行政部交接内容
        /// </summary>
        public string Dt_AdminContent { get; set; }
        /// <summary>
        /// 行政部交接情况
        /// </summary>
        public string Dt_AdminCase { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Dt_Remark { get; set; }
    }
}
