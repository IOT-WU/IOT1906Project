using DomainDTO.EFModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

/// <summary>
/// 流程控制器
/// </summary>
namespace Project.Controllers
{
    [ApiController]
    public class FlowController : BaseController
    {
        public FlowController(IConfiguration configuration) : base(configuration) { }

        /// <summary>
        /// 发起流程
        /// </summary>
        /// <param name="leave"></param>
        [HttpPost, Route("api/startleave")]
        public void StartLeave(LeaveEFModels leave)
        {
            StartProccess<LeaveEFModels>(leave);
        }
    }
}
