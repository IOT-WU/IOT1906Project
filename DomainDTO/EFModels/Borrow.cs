using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    
    public class Borrow
    {
        /// <summary>
        /// 固定资产资料借用单表
        /// </summary>
        [Key]
        /// <summary>
        /// 申请人id
        /// </summary>
        public int Borrow_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Borrow_applicant { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public int Borrow_Department { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime Borrow_Data { get; set; }
        /// <summary>
        /// 归还日期
        /// </summary>
        public DateTime Borrow_EndData { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string Borrow_Name { get; set; }
        /// <summary>
        /// 资产型号
        /// </summary>
        public string Borrow_Mode { get; set; }
        /// <summary>
        /// 资料名称
        /// </summary>
        public string Borrow_LName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Borrow_Note { get; set; }
    }
}
