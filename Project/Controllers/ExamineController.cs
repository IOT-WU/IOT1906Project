using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Project.Controllers
{
    /// <summary>
    /// 审批控制器
    /// </summary>
    [ApiController]
    public class ExamineController : BaseController
    {
        public ExamineController(IConfiguration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// 流程通过
        /// </summary>
        [HttpPost, Route("api/Approve")]
        public void Approve(ExamineModels models)
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
        public void RecedeRestart(ExamineModels models)
        {
            RecedeRestart(models);
        }
    }
}
