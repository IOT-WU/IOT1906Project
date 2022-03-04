using DomainDTO.EFModels;
using IRepository;
using IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDTO.InPutModels;

namespace Services
{
    /// <summary>
    /// 请假类型
    /// </summary>
    public class LeaveServices : ILeaveServices
    {
        private readonly IRepositoryDB<LeaveType> repository;
        private readonly IRepositoryDB<Annual_Leavetable> leavetable;
        public LeaveServices(IRepositoryDB<LeaveType> repository, IRepositoryDB<Annual_Leavetable> leavetable)
        {
            this.repository = repository;
            this.leavetable = leavetable;
        }

        /// <summary>
        /// 假期表显示
        /// </summary>
        /// <returns></returns>
        public List<Annual_Leavetabletext> GetAnnual(int aid)
        {
            var list = (from s in leavetable.QueryList(x => x.Aid.Equals(aid))
                        select new Annual_Leavetabletext
                        {
                            Aid=s.Aid,
                            Annual_judge=s.Annual_judge,
                            Annual_lastdays=s.Annual_lastdays,  
                            Annual_numberdays=s.Annual_numberdays,
                            Annual_startDate=s.Annual_startDate,
                        }).ToList();
            return list;
        }

        /// <summary>
        /// 假期表添加
        /// </summary>
        /// <param name="annual"></param>
        /// <returns></returns>
        public int GetAnnualadd(Annual_Leavetable annual)
        {
            return leavetable.ExecuteAdd(annual);
        }

        /// <summary>
        /// 获取请假类型集合
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<LeaveType> GetLeaveTypeList()
        {
            var ls = repository.QueryList(x => x.Id.Equals(x.Id));
            return ls;
        }

        /// <summary>
        /// 假期表修改
        /// </summary>
        /// <param name="aid"></param>
        /// <returns></returns>
        public int UptAnnual(Annual_Leavetable table)
        {
            var list = leavetable.ExecuteUpd(table);
            return list;
        }
    }
}
