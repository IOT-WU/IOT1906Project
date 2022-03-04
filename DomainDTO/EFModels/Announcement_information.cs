using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 公告基本信息表
    /// </summary>
    public class Announcement_information
    {
        [Key]
        /// <summary>
        /// 公告基本信息表主键
        /// </summary>
        public int Announcement_Fid { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string Announcement_type { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public string Announcement_date { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Announcement_title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Announcement_content { get; set; }

        /// <summary>
        /// 附件
        /// </summary>
        public string Announcement_attachment { get; set; }
    }
}
