using DomainDTO.EFModels;
using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [ApiController]
    public class VehicleController : ControllerBase
    {
        readonly IProductService _product;
        public VehicleController(IProductService product)
        {
            _product = product;
        }
        /// <summary>
        /// 车辆保险
        /// </summary>
        /// <param name="maintain"></param>
        /// <returns></returns>
        [HttpPost,Route("api/Addermaintain")]
        public IActionResult Addermaintain([FromBody]Maintain maintain)
        {
            return Ok(_product.Adder1(maintain));
        }
        /// <summary>
        /// 车辆保养
        /// </summary>
        /// <param name="mInsurance"></param>
        /// <returns></returns>
        [HttpPost, Route("api/AddermInsurance")]
    
        public IActionResult AddermInsurance([FromBody]MInsurance mInsurance)
        {
            return Ok(_product.Adder2(mInsurance));
        }
        [HttpPost, Route("api/Addermrepair")]
        /// <summary>
        /// 车辆维修记录表
        /// </summary>
        /// <param name="mrepair"></param>
        /// <returns></returns>
        public IActionResult Addermrepair([FromBody] Mrepair mrepair)
        {
            return Ok(_product.Adder3(mrepair));
        }
        [HttpPost, Route("api/AddermViolation")]
        /// <summary>
        /// 车辆违章记录
        /// </summary>
        /// <param name="mViolation"></param>
        /// <returns></returns>
        public IActionResult AddermViolation([FromBody] MViolation mViolation)
        {
            return Ok(_product.Adder4(mViolation));
        }
        /// <summary>
        /// 人力资源
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet,Route("api/findResources")]
        public IActionResult findResources(int id)
        {
            return Ok(_product.find(id));
        }
      
        /// <summary>
        /// 离职交接
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("api/findbPMSys")]
        public IActionResult findbPMSys(int id)
        {
            return Ok(_product.bPMSys(id));
        }

        /// <summary>
        /// 离职流程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("api/finddeparture")]
        public IActionResult finddeparture(int id)
        {
            return Ok(_product.departure(id));
        }
        /// <summary>
        /// 年度基础信息表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("api/findinformation")]
        public IActionResult findinformation(int id)
        {
            return Ok(_product.information(id));
        }
        /// <summary>
        /// 年度详情信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("api/findannual_Details")]
        public IActionResult findannual_Details(int id)
        {
            return Ok(_product.annual_Details(id));
        }
      
        /// <summary>
        /// 请假申请表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("api/findleave")]
        public IActionResult findleave(int id)
        {
            return Ok(_product.leave(id));
        }

        /// <summary>
        /// 员工面谈添加
        /// </summary>
        /// <param name="annual"></param>
        /// <returns></returns>
        [HttpPost, Route("api/GetExitInterviewadd")]
        public IActionResult GetExitInterviewadd(ExitInterview annual)
        {
            return Ok(_product.GetExitInterviewadd(annual));
        }

        /// <summary>
        /// 公告基本信息表添加
        /// </summary>
        /// <param name="annual"></param>
        /// <returns></returns>
        [HttpPost, Route("api/GetAnnouncementadd")]
        public IActionResult GetAnnouncementadd(Announcement_information Announcement)
        {
            return Ok(_product.GetAnnouncementadd(Announcement));
        }

        /// <summary>
        /// 文件管理表添加方法
        /// </summary>
        /// <param name="annual"></param>
        /// <returns></returns>
        [HttpPost, Route("api/GetFileadd")]
        public IActionResult GetFileadd(File_information File)
        {
            return Ok(_product.GetFileadd(File));
        }
        [HttpGet,Route("api/GitHandover")]
        /// <summary>
        /// 固定资产交接表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult GitHandover(int id)
        {
            return Ok(_product.GetHandover(id));
        }
        /// <summary>
        /// 用章基础信息表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet,Route("api/GitChapter")]
        public IActionResult GitChapter(int id)
        {
            return Ok(_product.departure(id));
        }
        [HttpGet,Route("api/GitAccdetailed")]
        /// <summary>
        /// 资产验收详细表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult GitAccdetailed(int id)
        {
            return Ok(_product.Gitaccdetailed(id));
        }
        [HttpGet,Route("api/Gitborrow")]
        /// <summary>
        /// 固定资产资料借用单表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Gitborrow(int id)
        {
            return Ok(_product.Gitborrow(id));
        }
        /// <summary>
        /// 车辆保险
        /// </summary>
        /// <param name="maintain"></param>
        /// <returns></returns>
        [HttpPost,Route("api/EditMaintain")]
        public IActionResult EditMaintain(Maintain maintain)
        {
            return Ok(_product.EditMaintain(maintain));
        }
        /// <summary>
        /// 车辆保养
        /// </summary>
        /// <param name="mInsurance"></param>
        /// <returns></returns>
        [HttpPost,Route("api/EditMInsurance")]
        public IActionResult EditMInsurance(MInsurance mInsurance)
        {
            return Ok(_product.EditMInsurance(mInsurance));
        }
        /// <summary>
        /// 车辆维修
        /// </summary>
        /// <param name="mrepair"></param>
        /// <returns></returns>
        [HttpPost,Route("api/EditMrepair")]
        public IActionResult EditMrepair(Mrepair mrepair)
        {
            return Ok(_product.EditMrepair(mrepair));
        }
        /// <summary>
        /// 车辆违章
        /// </summary>
        /// <param name="mViolation"></param>
        /// <returns></returns>
        [HttpPost,Route("api/EditMViolation")]
        public IActionResult EditMViolation(MViolation mViolation)
        {
            return Ok(_product.EditMViolation(mViolation));
        }
        [HttpGet,Route("api/GetReceptionTripDetails")]
        /// <summary>
        /// 接待申请行程详情表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult GetReceptionTripDetails(int id)
        {
            return Ok(_product.GetReceptionTripDetails(id));
        }
        [HttpGet,Route("api/GetSacceptance")]
        /// <summary>
        /// 固定资产验收基础表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult GetSacceptance(int id)
        {
            return Ok(_product.GetSacceptance(id));
        }
        /// <summary>
        /// 接待申请物品详情表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet,Route("api/GetReceptionItemsDetails")]
        public IActionResult GetReceptionItemsDetails(int id)
        {
            return Ok(_product.GetReceptionItemsDetails(id));
        }
        /// <summary>
        /// 日常用品采购详情表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet,Route("api/GetprocurementDetail")]
        public IActionResult GetprocurementDetails(int id)
        {
            return Ok(_product.GetprocurementDetails(id));
        }
        /// <summary>
        /// 日常用品采购表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet,Route("api/GetProcurement")]
        public IActionResult GetProcurement(int id)
        {
            return Ok(_product.GetProcurement(id));
        }
        /// <summary>
        /// 刻章申请表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet,Route("api/GetPrints_Information")]
        public IActionResult GetPrints_Information(int id)
        {
            return Ok(_product.GetPrints_Information(id));
        }
        /// <summary>
        /// 固定资产申请单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet,Route("api/GetFixedasse")]
        public IActionResult GetFixedasse(int id)
        {
            return Ok(_product.GetFixedasse(id));
        }
        [HttpGet,Route("api/GetCarApplication")]
        /// <summary>
        /// 用车申请表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult GetCarApplication(int id)
        {
            return Ok(_product.GetCarApplication(id));
        }
        [HttpGet,Route("api/GetReception")]
        /// <summary>
        /// 接待申请表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult GetReception(int id)
        {
            return Ok(_product.GetReception(id));
        }
    }
}
