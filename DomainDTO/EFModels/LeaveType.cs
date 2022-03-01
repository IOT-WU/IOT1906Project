using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 请假类型表
    /// </summary>
    public class LeaveType
    {
        public int Id { get; set; }
        public int Leave_TypeId { get; set; }
        public string Leave_TypeName { get; set; }
    }
}
