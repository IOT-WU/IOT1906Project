using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.InPutModels
{
    public class InputEmploye
    {
       
        /// <summary>
        /// 员工录入id
        /// </summary>
        public int Employed_Id { get; set; }

        public int TaskId { get; set; }
        /// <summary>
        /// 使用部门
        /// </summary>
        public int Employed_Department { get; set; }
        /// <summary>
        /// 核定日期
        /// </summary>
        public DateTime Employed_Date { get; set; }
        /// <summary>
        /// 岗位名称
        /// </summary>
        public string EmployedEntry_JobName { get; set; }
        /// <summary>
        /// 岗位说明
        /// </summary>
        public string Employed_Instruction { get; set; }
        /// <summary>
        /// 人员类别
        /// </summary>
        public string Employed_Categary { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>Employed
        /// 性别
        /// </summary>
        public bool Employed_Sex { get; set; }
        /// <summary>
        /// 出生年月
        /// </summary>
        public DateTime Employed_Year { get; set; }
        /// <summary>
        /// 文化程度
        /// </summary>
        public string Employed_Culture { get; set; }
        /// <summary>
        /// 健康状况
        /// </summary>
        public string Employed_Health { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Employed_Phone { get; set; }
        /// <summary>
        /// 住址
        /// </summary>
        public string Employed_Address { get; set; }
        /// <summary>
        /// 特长
        /// </summary>
        public string Employed_Specialty { get; set; }
        /// <summary>
        /// 是否有亲属在本公司工作
        /// </summary>
        public string Employed_Relative { get; set; }
        /// <summary>
        /// 拟定工资及待遇
        /// </summary>
        public string Employed_Treatment { get; set; }
        /// <summary>
        /// 合同期限
        /// </summary>
        public string Employed_Timelimit { get; set; }
        /// <summary>
        /// 试用期
        /// </summary>
        public string Employed_Thetrial { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Employed_Node { get; set; }
    }
}
