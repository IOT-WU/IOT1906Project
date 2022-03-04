using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Project.OtherApi;

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
        private ILeaveServices leaveServices;
        private IEmpServices iempServices;
        public FlowController(IConfiguration configuration, ILeaveServices leaveServices,IEmpServices iempServices) : base(configuration)
        {
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
        /// <summary>
        /// 离职申请流程
        /// </summary>
        /// <param name="departure"></param>
        [HttpPost, Route("api/startDeparture")]
        public void startDeparture(BPMDeparture departure)
        {
            var xml = CollectionToSqlXml<Departure>(departure.DepartureData);
            StartProccess(xml, departure);
        }

        /// <summary>
        /// 离职交接流程
        /// </summary>
        /// <param name="departure"></param>
        [HttpPost, Route("api/startDeparturetTransfer")]
        public void startDeparturetTransfer(BPMDeparturetTransfer departure)
        {
            var xml = CollectionToSqlXml<DeparturetTransfer>(departure.DeparturetTransferData);
            StartProccess(xml, departure);
        }

        /// <summary>
        /// 用车申请流程
        /// </summary>
        /// <param name="departure"></param>
        [HttpPost, Route("api/startCarApplication")]
        public void startCarApplication(BPMCarApplication carApplication)
        {
            var xml = CollectionToSqlXml<CarApplication>(carApplication.CarApplicationData);
            StartProccess(xml, carApplication);
        }
        /// <summary>
        /// 采购申请流程
        /// </summary>
        /// <param name="plan"></param>
        [HttpPost, Route("api/stratProcurement")]
        public void stratProcurement(ProcurementTransfer plan)
        {
            var xml = CollectionToSqlXml<Procurement>(plan.ProcurementData);
            var xml1 = CollectionToSqlXml<ProcurementDetails>(plan.ProcurementDetailsDetail);

            StartProccess(xml + xml1, plan);
        }
        /// <summary>
        /// 接待申请流程
        /// </summary>
        /// <param name="plan"></param>
        [HttpPost, Route("api/stratReception")]
        public void stratReception(ReceptionTransfer plan)
        {
            var xml = CollectionToSqlXml<Reception>(plan.ReceptionData);
            var xml1 = CollectionToSqlXml<ReceptionItemsDetails>(plan.ReceptionItemsDetailsDetail);
            var xmll1 = CollectionToSqlXml<ReceptionTripDetails>(plan.ReceptionTripDetailsDetail);

            StartProccess(xml + xml1 + xmll1, plan);
        }

        /// <summary>
        /// 用章申请流程
        /// </summary>
        /// <param name="departure"></param>
        [HttpPost, Route("api/startChaptertion")]
        public void startChaptertion(Chapter_text chapter)
        {
            var xml = CollectionToSqlXml<Chapter_information>(chapter.chaptertext);
            StartProccess(xml, chapter);
        }

        /// <summary>
        /// 刻章申请流程
        /// </summary>
        /// <param name="departure"></param>
        [HttpPost, Route("api/startPrintstion")]
        public void startPrintstion(Prints_text prints)
        {
            var xml = CollectionToSqlXml<Prints_information>(prints.printstext);
            StartProccess(xml, prints);
        }

        /// <summary>
        /// 年度计划流程
        /// </summary>
        /// <param name="plan"></param>
        [HttpPost, Route("api/stratPlan")]
        public void StartPlan(Annual_textto plan)
        {
            var xml = CollectionToSqlXml<Annual_information>(plan.PlanData);
            var xml1 = CollectionToSqlXml<Annual_details>(plan.PlanInfoDetail);

            StartProccess(xml + xml1, plan);
        }
        /// <summary>
        /// 人力资源申请流程
        /// </summary>
        /// <param name="plan"></param>
        [HttpPost, Route("api/stratResources")]
        public void stratResources(BPMResources plan)
        {
            var xml = CollectionToSqlXml<Resources>(plan.ResourcesData);
            StartProccess(xml, plan);
        }

      

    }
}
