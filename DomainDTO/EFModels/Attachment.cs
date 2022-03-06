using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class Attachment
    {
        [Key]
        /// <summary>
        /// 固定资产验收附件详细信息表
        /// </summary>
        public int Attachment_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 附件说明
        /// </summary>
        public string Attachment_Shuo { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Attachment_Single { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string Attachment_Num { get; set; }
        /// <summary>
        /// 保管人
        /// </summary>
        public string Attachment_People { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string Attachment_Attment { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Attachment_Note { get; set; }
    }
}
