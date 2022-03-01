using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class Departure
    {
        [Key]
        public int Departure_Id { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Departure_Applicant { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Departure_Department { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime Departure_Time { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public string Departure_Position { get; set; }
        /// <summary>
        /// 入职日期
        /// </summary>
        public DateTime Departure_Entry { get; set; }
        /// <summary>
        /// 离职日期
        /// </summary>
        public DateTime Departure_Data { get; set; }
        /// <summary>
        /// 离职类型
        /// </summary>
        public int Departure_Type { get; set; }
        /// <summary>
        /// 离职原因
        /// </summary>
        public string Departure_Why { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Departure_Note { get; set; }

    }
}
