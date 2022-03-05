using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
   
    public class Fixedasse
    {
        /// <summary>
        /// 固定资产申请单
        /// </summary>
        [Key]
        public int assets_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string assets_Applicant { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public int assets_Department { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime assets_Data { get; set; }
        /// <summary>
        /// 表单单号--自动生成
        /// </summary>
        public string assets_Order { get; set; }
        /// <summary>
        /// 固定资产名称
        /// </summary>
        public string assets_Name { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        public string assets_Nodel { get; set; }
        /// <summary>
        /// 配置
        /// </summary>
        public string assets_Configution { get; set; }
        /// <summary>
        /// 是否生产资产
        /// </summary>
        public int assets_Not { get; set; }
        /// <summary>
        /// 申请理由
        /// </summary>
        public string assets_Reason { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string assets_Note { get; set; }
    }
}
