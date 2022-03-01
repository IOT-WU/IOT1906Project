using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class ReceptionItemsDetails
    {
        /// <summary>
        /// 接待申请物品详情表
        /// </summary>
        [Key]
        public int Items_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 物品名称
        /// </summary>
        public string Items_Name { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Items_Specifications { get; set; }
        /// <summary>
        /// 使用数量
        /// </summary>
        public string Items_UseNumber { get; set; }
        /// <summary>
        /// 库存数量
        /// </summary>
        public string Items_InventoryQuantity { get; set; }
        /// <summary>
        /// 剩余数量
        /// </summary>
        public string Items_NumberRemaining { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Items_Note { get; set; }
    }
}
