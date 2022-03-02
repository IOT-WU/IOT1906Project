using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class Procurement:BaseModels
    {
        /// <summary>
        /// 日常用品采购表
        /// </summary>
        [Key]
        public int Procurement_Id { get; set; }
        public int TaskId { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public string Procurement_Applicant { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string Procurement_Agent { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Procurement_ApplyDepartment { get; set; }
        /// <summary>
        /// 经办部门
        /// </summary>
        public string Procurement_HandlingDepartment { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string Procurement_ApplyTime { get; set; }
        /// <summary>
        /// 经办日期
        /// </summary>
        public string Procurement_HandlingTime { get; set; }
        /// <summary>
        /// 用途
        /// </summary>
        public string Procurement_Use { get; set; }
    }
}
