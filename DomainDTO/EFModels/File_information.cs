using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 文件管理表
    /// </summary>
    public class File_information
    {
        [Key]
        /// <summary>
        /// 文件管理表主键
        /// </summary>
        public int File_Mid { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        public string File_type { get; set; }

        /// <summary>
        /// 文件所属部门
        /// </summary>
        public int File_department { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string File_name { get; set; }

        /// <summary>
        /// 归档日期
        /// </summary>
        public string File_date { get; set; }

        /// <summary>
        /// 文件编号
        /// </summary>
        public string File_number { get; set; }

        /// <summary>
        /// 归档人
        /// </summary>
        public string File_Archive { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string File_content { get; set; }

        /// <summary>
        /// 附件
        /// </summary>
        public string File_attachment { get; set; }
    }
}
