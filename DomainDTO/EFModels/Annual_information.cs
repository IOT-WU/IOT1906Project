using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 年度基础信息表
    /// </summary>
    public class Annual_information /*:BaseModels*/
    {
        [Key]
        /// <summary>
        /// 年度基础信息表主键（不可修改）
        /// </summary>
        public int Annual_Fid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// 制表人-当前登录人账号不可填写
        /// </summary>
        public string TAB_people { get; set; }

        /// <summary>
        /// 制表时间-当前登录人账号不可填写
        /// </summary>
        public DateTime TAB_time { get; set; }

        /// <summary>
        /// 制表部门-当前登录人账号不可填写
        /// </summary>
        public int TAB_department { get; set; }

        /// <summary>
        /// 制表年份-可填写
        /// </summary>
        public DateTime TAB_year { get; set; }
    }
}
