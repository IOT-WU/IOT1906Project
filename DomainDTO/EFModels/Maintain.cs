using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
   public class Maintain
    {
        [Key]
        public int vehicle_BId { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string vehicle_Handler { get; set; }
        /// <summary>
        /// 保养日期
        /// </summary>
        public DateTime vehicle_datime { get; set; }
        /// <summary>
        /// 保养原因
        /// </summary>
        public string vehicle_reason { get; set; }
        /// <summary>
        /// 保养项目
        /// </summary>
        public string vehicle_project { get; set; }
        /// <summary>
        /// 保养单元
        /// </summary>
        public string vehicle_Company { get; set; }
        /// <summary>
        /// 保养费用
        /// </summary>
        public string vehicle_cost { get; set; }
        /// <summary>
        /// 保养当时公里数
        /// </summary>
        public string vehicle_Kilometers { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string vehicle_remarks { get; set; }
    }
}
