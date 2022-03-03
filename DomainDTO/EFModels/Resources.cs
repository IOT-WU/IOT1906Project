using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
   public class Resources
    {
        /// <summary>
        /// 人力资源需求申请单
        /// </summary>
        [Key] 
        public int staff_Id { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string staff_department { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime staff_time { get; set; }
        /// <summary>
        /// 岗位名称
        /// </summary>
        public string staff_name { get; set; }
        /// <summary>
        /// 岗位说明
        /// </summary>
        public string staff_explain { get; set; }
        /// <summary>
        /// 现有人数
        /// </summary>
        public int staff_existing { get; set; }
        /// <summary>
        /// 招聘人数
        /// </summary>
        public int staff_recruit { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string staff_sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int staff_age { get; set; }
        /// <summary>
        /// 文化程度
        /// </summary>
        public string staff_Culture { get; set; }
        /// <summary>
        /// 专业要求
        /// </summary>
        public string staff_major { get; set; }
        /// <summary>
        /// 岗位要求
        /// </summary>
        public string staff_post { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string staff_other { get; set; }
        /// <summary>
        /// 薪资待遇
        /// </summary>
        public string staff_Salary { get; set; }
        /// <summary>
        /// 拟聘合同
        /// </summary>
        public string staff_contract { get; set; }
        /// <summary>
        /// 试用期
        /// </summary>
        public DateTime staff_probation { get; set; }
        /// <summary>
        /// 申请原因
        /// </summary>
        public string staff_application { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string staff_enclosure { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string staff_remarks { get; set; }
    }
}
