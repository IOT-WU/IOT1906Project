using DomainDTO.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.InPutModels
{
    public class BPMDeparture : BaseModels
    {

        /// <summary>
        /// 存放Departure的xml字符串
        /// </summary>
        public string DepartureData { get; set; }
    }
}
