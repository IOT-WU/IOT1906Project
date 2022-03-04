
using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Project.Controllers
{
    [ApiController]
    public class PersonnelManageController : BaseController
    {
        public PersonnelManageController(IConfiguration configuration) : base(configuration)
        {
        }
        /// <summary>
        /// 员工录用发起流程
        /// </summary>
        /// <param name="palnall"></param>
        [HttpPost, Route("api/Startemployed")]
        public void Startemployed(InputPlanAll palnall)
        {
            var Employe = CollectionToSqlXml<Employe>(palnall.PlanData);
            var Relati = CollectionToSqlXml<Relati>(palnall.PlanInfoDetail);
            StartProccess(Employe + Relati, palnall);

        }
        /// <summary>
        /// 固定资产申请发起流程
        /// </summary>
        /// <param name="palnall"></param>
        [HttpPost, Route("api/StartFixedasse")]
        public void StartFixedasse(InputPlanAll palnall)
        {
            var Fixedasse = CollectionToSqlXml<Fixedasse>(palnall.PlanData);
            
            StartProccess(Fixedasse, palnall);

        }
        /// <summary>
        /// 固定资产资料借用发起流程
        /// </summary>
        /// <param name="palnall"></param>
        [HttpPost, Route("api/StartBorrow")]
        public void StartBorrow(InputPlanAll palnall)
        {
            var Borrow = CollectionToSqlXml<Borrow>(palnall.PlanData);

            StartProccess(Borrow, palnall);

        }
        /// <summary>
        /// 固定资产交接发起流程
        /// </summary>
        /// <param name="palnall"></param>
        [HttpPost, Route("api/StartHandover")]
        public void StartHandover(InputPlanAll palnall)
        {
            var Handover = CollectionToSqlXml<Handover>(palnall.PlanData);

            StartProccess(Handover, palnall);

        }
        /// <summary>
        /// 固定资产验收发起流程
        /// </summary>
        /// <param name="palnall"></param>
        [HttpPost, Route("api/StartAccMent")]
        public void StartAccMent(InputPlanAll palnall)
        {
            var Accdetailed = CollectionToSqlXml<Accdetailed>(palnall.PlanData);
            var Attachment = CollectionToSqlXml<Attachment>(palnall.PlanInfoDetail);
            var Sacceptance = CollectionToSqlXml<Sacceptance>(palnall.PlanInfoMen);
            StartProccess(Accdetailed + Attachment+ Sacceptance, palnall);

        }





    }
}