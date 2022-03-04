using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

/// <summary>
/// 流程控制器
/// </summary>
namespace Project.Controllers
{
    [ApiController]
    public class FlowController : BaseController
    {
        private IConfiguration configuration;
        private ILeaveServices leaveServices;
        private IEmpServices iempServices;
        public FlowController(IConfiguration configuration, ILeaveServices leaveServices,IEmpServices iempServices) : base(configuration)
        {
            this.configuration = configuration;
            this.leaveServices = leaveServices;
            this.iempServices = iempServices;
        }

        /// <summary>
        /// 获取请假类型
        /// </summary>
        /// <returns></returns>
        [HttpGet,Route("api/GetLeaveType")]
        public List<LeaveType> GetLeaveType()
        {
            var ls = leaveServices.GetLeaveTypeList();
            return ls;
        }
        /// <summary>
        /// 获取部门
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("api/GetDepat")]
        public List<BPMSysOUs> GetDepat()
        {
            var list = iempServices.Bind();
            return list;
        }
        //获得角色
        [HttpGet, Route("api/GetOutRole")]
        public List<BPMSysOURoles> GetOutRole(int OUID)
        {
            var list = iempServices.RoleBind(OUID);
            return list;
        }

        /// 发起请假流程
        /// </summary>
        /// <param name="leave"></param>
        [HttpPost, Route("api/startleave")]
        public void StartLeave(BPMLeaveModels leave)
        {
            var xml = CollectionToSqlXml<Leave>(leave.LeaveData);
            StartProccess(xml, leave);
        }

      

    }
}
