using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DomainDTO.EFModels
{
   public class MViolation
    {
        /// <summary>
        /// 车辆违章记录
        /// </summary>
        [Key]
        public int DId { get; set; }
        
       
        /// <summary>
        /// 经办人
        /// </summary>
        public string Handler { get; set; }
        /// <summary>
        /// 处理日期
        /// </summary>
        public DateTime time { get; set; }
        /// <summary>
        /// 车辆违章日期
        /// </summary>
        public DateTime date { get; set; }
        /// <summary>
        /// 违章驾驶员
        /// </summary>
        public string drive { get; set; }
        /// <summary>
        /// 车辆违章事由
        /// </summary>
        public string Violation { get; set; }
        /// <summary>
        /// 罚款金额
        /// </summary>
        public string money { get; set; }
        /// <summary>
        /// 扣分
        /// </summary>
        public int points { get; set; }
        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime handle { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remarks { get; set; }
    }
}
