using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.InPutModels
{
    public class ReceptionTransfer:BaseModels
    {
        public string ReceptionData { get; set; }
        public string ReceptionItemsDetailsDetail { get; set; }
        public string ReceptionTripDetailsDetail { get; set; }
    }
}
