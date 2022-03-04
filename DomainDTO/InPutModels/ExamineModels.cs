using DomainDTO.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.InPutModels
{
    public class ExamineModels : BaseModels
    {
        /// <summary>
        /// 流程ID
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 意见
        /// </summary>
        public string Comments { get; set; }
    }
}
