using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
   public class MInsurance
    {
        /// <summary>
        /// 车辆保险纪录表
        /// </summary>
        [Key]
        public int car_AId { get; set; }
       
        /// <summary>
        /// 经办人
        /// </summary>
        public string car_Handler { get; set; }
        /// <summary>
        /// 制表时间
        /// </summary>
        public DateTime car_Tabulation { get; set; }
        /// <summary>
        /// 车型
        /// </summary>
        public string car_Model { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string car_number { get; set; }
        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime car_purchase { get; set; }
        /// <summary>
        /// 座位数
        /// </summary>
        public int car_seat { get; set; }
        /// <summary>
        /// 保险金额
        /// </summary>
        public string car_money { get; set; }
        /// <summary>
        /// 乘客险
        /// </summary>
        public string car_passenger { get; set; }
        /// <summary>
        /// 保险项目
        /// </summary>
        public string car_project { get; set; }
        /// <summary>
        /// 截至保险日期
        /// </summary>
        public DateTime car_Insurance { get; set; }
        /// <summary>
        /// 保险开始日期
        /// </summary>
        public DateTime car_strat { get; set; }
        /// <summary>
        /// 保险结束日期
        /// </summary>
        public DateTime car_end { get; set; }
    }
}
