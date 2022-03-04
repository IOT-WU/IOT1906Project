using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IServices;
using Services;
using DomainDTO.EFModels;

namespace Project.Controllers
{
    [ApiController]
    public class VacationController : ControllerBase
    {
        private readonly ILeaveServices leaveServices;
        public VacationController(ILeaveServices leaveServices)
        {
            this.leaveServices = leaveServices;
        }

        /// <summary>
        /// 假期表显示方法
        /// </summary>
        /// <returns></returns>
        [HttpGet,Route("api/GetAnnual")]
        public IActionResult GetAnnual(int aid)
        {
            return Ok(leaveServices.GetAnnual(aid));
        }

        /// <summary>
        /// 假期表添加方法
        /// </summary>
        /// <param name="annual"></param>
        /// <returns></returns>
        [HttpPost, Route("api/GetAnnualadd")]
        public IActionResult GetAnnualadd(Annual_Leavetable annual)
        {
            return Ok(leaveServices.GetAnnualadd(annual));
        }


        /// <summary>
        /// 假期表修改方法
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        [HttpPost, Route("api/UptAnnual")]
        public IActionResult UptAnnual(Annual_Leavetable table)
        {
            return Ok(leaveServices.UptAnnual(table));
        }
    }
}
