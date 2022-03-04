using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 年度假期表
    /// </summary>
    public class Annual_Leavetable
    {
        /// <summary>
        /// 年度假期表主键
        /// </summary>
        [Key]
        public int Aid { get; set; }

        /// <summary>
        /// 今年的年假天数
        /// </summary>
        public string Annual_numberdays { get; set; }

        /// <summary>
        /// 去年的年假天数
        /// </summary>
        public string Annual_lastdays { get; set; }

        /// <summary>
        /// 入职日期
        /// </summary>
        public string Annual_startDate { get; set; }

        /// <summary>
        /// 判断是否显示（假删除字段）
        /// </summary>
        public int Annual_judge { get; set; }
}
}
