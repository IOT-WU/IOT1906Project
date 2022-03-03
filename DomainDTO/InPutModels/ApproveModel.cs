using DomainDTO.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.InPutModels
{
    public class ApproveModel : BaseModels
    {
        /// <summary>
        /// 流程节点ID
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// 意见
        /// </summary>
        public string Comments { get; set; }
    }
}
