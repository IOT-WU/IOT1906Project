using DomainDTO.EFModels;
using IRepository;
using IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// 请假类型
    /// </summary>
    public class LeaveServices : ILeaveServices
    {
        private readonly IRepositoryDB<LeaveType> repository;
        public LeaveServices(IRepositoryDB<LeaveType> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// 获取请假类型集合
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<LeaveType> GetLeaveTypeList()
        {
            var ls = repository.QueryList(x=>x.Id.Equals(x.Id));
            return ls;
        }
    }
}
