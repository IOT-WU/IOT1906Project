using DomainDTO.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.InPutModels
{
    public class ProcurementTransfer:BaseModels
    {
        public string ProcurementData { get; set; }
        public string ProcurementDetailsDetail { get; set; }
    }
}
