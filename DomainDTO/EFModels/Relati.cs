using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 员工亲属详细信息
    /// </summary>
    public class Relati
    {
        [Key]
        /// <summary>
        /// 员工亲属id
        /// </summary>
        public int Relative_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 亲属名称
        /// </summary>
        public string Relative_Name { get; set; }
        /// <summary>
        /// 与本人关系
        /// </summary>
        public string Relative_Between { get; set; }
        /// <summary>
        /// 亲属在公司任何部门工作、任何职务
        /// </summary>
        public string Relative_Position { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Relative_Note { get; set; }

    }
}
