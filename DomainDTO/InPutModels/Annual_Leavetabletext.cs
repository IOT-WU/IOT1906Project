using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.InPutModels
{
    public class Annual_Leavetabletext
    {
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
