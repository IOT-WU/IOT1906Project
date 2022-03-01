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
        [HttpPost, Route("api/stratProcurement")]
        public void stratProcurement(ProcurementTransfer plan)
        {
            var xml = CollectionToSqlXml<Procurement>(plan.ProcurementData);
            var xml1 = CollectionToSqlXml<ProcurementDetails>(plan.ProcurementDetailsDetail);

            StartProccess(xml + xml1, plan);
        }

        [HttpPost, Route("api/stratReception")]
        public void stratReception(ReceptionTransfer plan)
        {
            var xml = CollectionToSqlXml<Reception>(plan.ReceptionData);
            var xml1 = CollectionToSqlXml<ReceptionItemsDetails>(plan.ReceptionItemsDetailsDetail);
            var xmll1 = CollectionToSqlXml<ReceptionTripDetails>(plan.ReceptionTripDetailsDetail);

            StartProccess(xml + xml1 + xmll1, plan);
        }

    }
}