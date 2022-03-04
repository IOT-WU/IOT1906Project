using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class Accdetailed
    {
        [Key]
        /// <summary>
        /// 资产验收详细表
        /// </summary>
        public int Accdetailed_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string Accdetailed_Name { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string Accdetailed_XMode { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string Accdetailed_Num { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public string Accdetailed_Price { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public string Accdetailed_Ammount { get; set; }
        /// <summary>
        /// 供货单位
        /// </summary>
        public string Accdetailed_Unit { get; set; }
        /// <summary>
        /// 采购人
        /// </summary>
        public string Accdetailed_Procurement { get; set; }
    }
}
