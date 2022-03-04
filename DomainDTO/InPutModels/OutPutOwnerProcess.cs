﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.InPutModels
{
    public class OutPutOwnerProcess
    {
        public int Key { get; set; }
        public string SerialNum { get; set; }
        public string ProcessName { get; set; }
        public string OwnerAccount { get; set; }
        public DateTime CreateAt { get; set; }
        public string NodeName { get; set; }
        public int TaskID { get; set; }
        public int StepID { get; set; }
        public string NodeOwnerAccount { get; set; }
    }
}
