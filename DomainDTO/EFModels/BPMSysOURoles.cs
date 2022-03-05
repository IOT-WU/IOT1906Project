using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{ 
    //[NotMapped]
    public class BPMSysOURoles
    {
       
        [Key]
        public int OUID { get; set; }
        public string RoleName { get; set; }
        public string SId { get; set; }
    }
}
