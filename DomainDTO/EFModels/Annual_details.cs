using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 年度详情信息表
    /// </summary>
    public class Annual_details
    {
        [Key]
        /// <summary>
        /// 年度详情信息表主键（不可修改）
        /// </summary>
        public int Annual_Did { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 详细岗位-可修改
        /// </summary>
        public int Annual_jobs { get; set; }

        /// <summary>
        /// 详细上年已有（不可修改）
        /// </summary>
        public string Annual_existing { get; set; }

        /// <summary>
        /// 详细1月份-可修改
        /// </summary>
        public int Annual_January { get; set; }

        /// <summary>
        /// 详细2月份-可修改
        /// </summary>
        public int Annual_February { get; set; }

        /// <summary>
        /// 详细3月份-可修改
        /// </summary>
        public int Annual_march { get; set; }

        /// <summary>
        /// 详细4月份-可修改
        /// </summary>
        public int Annual_April { get; set; }

        /// <summary>
        /// 详细5月份-可修改
        /// </summary>
        public int Annual_may { get; set; }

        /// <summary>
        /// 详细6月份-可修改
        /// </summary>
        public int Annual_June { get; set; }

        /// <summary>
        /// 详细7月份-可修改
        /// </summary>
        public int Annual_July { get; set; }

        /// <summary>
        /// 详细8月份-可修改
        /// </summary>
        public int Annual_August { get; set; }

        /// <summary>
        /// 详细9月份-可修改
        /// </summary>
        public int Annual_September { get; set; }

        /// <summary>
        /// 年度10月份-可修改
        /// </summary>
        public int Annual_October { get; set; }

        /// <summary>
        /// 年度11月份-可修改
        /// </summary>
        public int Annual_November { get; set; }

        /// <summary>
        /// 年度12月份-可修改
        /// </summary>
        public int Annual_December { get; set; }

        /// <summary>
        /// 年度合计-可修改
        /// </summary>
        public int Annual_combined { get; set; }

        /// <summary>
        /// 备注-可修改
        /// </summary>
        public string Annual_note { get; set; }
        
      
    }
}
