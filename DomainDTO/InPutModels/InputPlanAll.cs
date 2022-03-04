using DomainDTO.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.InPutModels
{
    public class InputPlanAll:BaseModels
    {
        public string PlanData { get; set; }

        public string PlanInfoDetail { get; set; }
        public string PlanInfoMen { get; set; }
    }
}
