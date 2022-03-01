using Api.Controllers;
using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Shopping.EF.SqlXML;
using System;

namespace Project.Controllers
{
    [ApiController]
    public class PersonnelManageController : BaseController
    {

        public PersonnelManageController(IConfiguration configuration) : base(configuration)
        {

        }
        [HttpPost, Route("api/stratPlan")]
        public void StartPlan(Annual_textto plan)
        {
            var xml = CollectionToSqlXml<Annual_information>(plan.PlanData);
            var xml1 = CollectionToSqlXml<Annual_details>(plan.PlanInfoDetail);

            StartProccess(xml + xml1, plan);
        }
       
    }
}