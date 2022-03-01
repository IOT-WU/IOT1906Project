using DomainDTO.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.InPutModels
{
    public class BPMLeaveModels : BaseModels
    {
        /// <summary>
        /// 存放Leave的xml字符串
        /// </summary>
        public string LeaveData { get; set; }
    }
}
