﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class LeaveEFModel
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Day { get; set; }
    }
}
