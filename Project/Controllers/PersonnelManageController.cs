
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
        [HttpPost, Route("api/Startemployed")]
        public void Startemployed(InputPlanAll palnall)
        {
            var Employe = CollectionToSqlXml<Employe>(palnall.PlanData);
            var Relati = CollectionToSqlXml<Relati>(palnall.PlanInfoDetail);
            StartProccess(Employe + Relati, palnall);

        }




    }
}