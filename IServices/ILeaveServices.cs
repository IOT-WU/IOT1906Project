using DomainDTO.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DomainDTO.InPutModels;

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

        /// <summary>
        /// 假期表添加方法
        /// </summary>
        /// <param name="annual"></param>
        /// <returns></returns>
        int GetAnnualadd(Annual_Leavetable annual);

        /// <summary>
        /// 假期表显示方法
        /// </summary>
        /// <returns></returns>
        List<Annual_Leavetabletext> GetAnnual(int aid);

        /// <summary>
        /// 假期表修改方法
        /// </summary>
        /// <param name="aid"></param>
        /// <returns></returns>
        int UptAnnual(Annual_Leavetable table);
    }
}
