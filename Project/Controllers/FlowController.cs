using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project.OtherApi;
using System;
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
        public FlowController(IConfiguration configuration) : base(configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// 发起请假流程
        /// </summary>
        /// <param name="leave"></param>
        [HttpPost, Route("api/startleave")]
        public void StartLeave(BPMLeaveModels leave)
        {
            var xml = CollectionToSqlXml<BPMLeaveModels>(leave.LeaveData);
            StartProccess(xml,leave);
        }

        [HttpPost, Route("api/startDeparture")]
        public void startDeparture(Departure departure)
        {
            var xml = "";
            StartProccess(xml,departure);
        }
    }
}
