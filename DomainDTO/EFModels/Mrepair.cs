using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DomainDTO.EFModels
{
   public class Mrepair
    {
        /// <summary>
        /// 车辆维修记录表
        /// </summary>
        [Key]
        public int CId { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string Handler { get; set; }
        /// <summary>
        /// 维修日期
        /// </summary>
        public DateTime time { get; set; }
        /// <summary>
        /// 维修项目
        /// </summary>
        public string project { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 维修当时公里数
        /// </summary>
        public string Kilometers { get; set; }
        /// <summary>
        /// 维修费用
        /// </summary>
        public string cost { get; set; }
        /// <summary>
        /// 出故障人员
        /// </summary>
        public string fault { get; set; }
        /// <summary>
        /// 出故障日期
        /// </summary>
        public DateTime date { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remarks { get; set; }
    }
}
