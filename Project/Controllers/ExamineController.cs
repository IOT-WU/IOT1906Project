using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace Project.Controllers
{
    /// <summary>
    /// 审批控制器
    /// </summary>
    [ApiController]
    public class ExamineController : BaseController
    {

        private readonly IUserServices userServices;
        public ExamineController(IConfiguration configuration, IUserServices userServices) : base(configuration)
        {
            this.userServices = userServices;
        }

        /// <summary>
        /// 获取正在审核的流程
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        [HttpGet, Route("api/Process")]
        public IActionResult GetTask(string account, int pageindex, int pagesize)
        {
            return Ok(userServices.GetRunningProcess(account, pageindex, pagesize));
        }
        /// <summary>
        /// 获取已处理的流程
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        [HttpGet, Route("api/GetDisposeProcess")]
        public IActionResult GetDispose(string account, int pageindex, int pagesize)
        {
            return Ok(userServices.GetRunningProcess(account, pageindex, pagesize));
        }
        /// <summary>
        /// 获取正在审核的流程
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        [HttpGet, Route("api/GetMyProcess")]
        public IActionResult GetMyProcess(string account, int pageindex, int pagesize)
        {
            return Ok(userServices.GetRunningProcess(account, pageindex, pagesize));
        }

        /// <summary>
        /// 流程通过
        /// </summary>
        [HttpPost, Route("api/Approve")]
        public void Approve(ApproveModel models)
        {
            ApproveProccess(models);
        }
        /// <summary>
        /// 流程拒绝
        /// </summary>
        [HttpPost, Route("api/Reject")]
        public void Reject(ExamineModels models)
        {
            RejectProccess(models);
        }
        /// <summary>
        /// 流程驳回
        /// </summary>
        [HttpPost, Route("api/RecedeRestart")]
        public void RecedeRestart1(ExamineModels models)
        {
            RecedeRestart(models);
        }
        /// <summary>
        /// 获取表单路径
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        [HttpPost,Route("api/GetUrl")]
        public Task<string> GetUrl(BaseModels models)
        {
            return GetPostUrl(models);
        }
    }
}
