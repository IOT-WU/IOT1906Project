using DomainDTO.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    /// <summary>
    /// 请假接口
    /// </summary>
    public interface ILeaveServices
    {
        /// <summary>
        /// 获取请假类型
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<LeaveType> GetLeaveTypeList();
    }
}
