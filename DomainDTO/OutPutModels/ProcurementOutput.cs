using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.OutPutModels
{
    public class ProcurementOutput
    {
        public int Goods_Id { get; set; }
        public int TaskId { get; set; }

        /// <summary>
        /// 用品名称
        /// </summary>
        public string Goods_Name { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Goods_Specifications { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string Goods_Num { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Goods_Unit { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public string Goods_Price { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public string Goods_Money { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Goods_Note { get; set; }
    }
}
