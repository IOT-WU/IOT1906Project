using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class PlanAll:BaseModels
    {
        [Key]
        public int PlanId { get; set; }
        public string PlanData { get; set; }

        public string PlanInfoDetail { get; set; }
    }
}
