using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 刻章申请表
    /// </summary>
    public class Prints_information  /*: BaseModels*/
    {
        [Key]
        /// <summary>
        /// 刻章申请表主键
        /// </summary>
        public int Prints_Rid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public string Prints_applicant { get; set; }

        /// <summary>
        /// 申请部门
        /// </summary>
        public int Prints_department { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        public string Prints_date { get; set; }

        /// <summary>
        /// 刻章名称
        /// </summary>
        public string Prints_printsname { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        public string Prints_use { get; set; }

        /// <summary>
        /// 刻章留印标记
        /// </summary>
        public string Prints_tag { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Prints_note { get; set; }
    }
}
