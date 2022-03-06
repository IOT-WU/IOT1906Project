using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class Handover
    {
        /// <summary>
        /// 固定资产交接表
        /// </summary>
        [Key]
        public int Handover_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Handover_Apply { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public int Handover_Department { get; set; }
        /// <summary>
        /// /申请日期
        /// </summary>
        public DateTime Handover_Date { get; set; }
        /// <summary>
        /// 交错单号
        /// </summary>
        public int Handover_Order { get; set; }
        /// <summary>
        /// 资产编号
        /// </summary>
        /// 
        public string Handover_Card { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string Handover_ZName { get; set; }
        /// <summary>
        /// 交错人
        /// </summary>
        public string Handover_Name { get; set; }

        /// <summary>
        /// 交错部门
        /// </summary>
        public string Handover_Depar { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Handover_Note { get; set; }
    }
}
