using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 用章基础信息表
    /// </summary>
    public class Chapter_information /*: BaseModels*/
    {
        [Key]
        /// <summary>
        /// 用章申请表
        /// </summary>
        public int Chapter_Pid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public string Chapter_applicant { get; set; }

        /// <summary>
        /// 申请部门
        /// </summary>
        public int Chapter_department { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        public string Chapter_date { get; set; }

        /// <summary>
        /// 印章名称
        /// </summary>
        public string Chapter_sealname { get; set; }

        /// <summary>
        /// 是否外借
        /// </summary>
        public string Chapter_Checkedout { get; set; }

        /// <summary>
        /// 陪同人员
        /// </summary>
        public string Chapter_Accompanying { get; set; }

        /// <summary>
        /// 归还日期
        /// </summary>
        public string Chapter_returndate { get; set; }

        /// <summary>
        /// 外出地址
        /// </summary>
        public string Chapter_address { get; set; }

        /// <summary>
        /// 用印事项或主要内容
        /// </summary>
        public string Chapter_content { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Chapter_note { get; set; }
    }
}
