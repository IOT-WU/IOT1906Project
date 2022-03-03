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
    [Route("api/[controller]")]
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
        [HttpPost,Route("api/Adder1")]
        public IActionResult Adder1([FromBody]Maintain maintain)
        {
            return Ok(_product.Adder1(maintain));
        }
        /// <summary>
        /// 车辆保养
        /// </summary>
        /// <param name="mInsurance"></param>
        /// <returns></returns>
        [HttpPost, Route("api/Adder2")]
    
        public IActionResult Adder2([FromBody]MInsurance mInsurance)
        {
            return Ok(_product.Adder2(mInsurance));
        }
        [HttpPost, Route("api/Adder3")]
        /// <summary>
        /// 车辆维修记录表
        /// </summary>
        /// <param name="mrepair"></param>
        /// <returns></returns>
        public IActionResult Adder3([FromBody] Mrepair mrepair)
        {
            return Ok(_product.Adder3(mrepair));
        }
        [HttpPost, Route("api/Adder4")]
        /// <summary>
        /// 车辆违章记录
        /// </summary>
        /// <param name="mViolation"></param>
        /// <returns></returns>
        public IActionResult Adder4([FromBody] MViolation mViolation)
        {
            return Ok(_product.Adder4(mViolation));
        }
        /// <summary>
        /// 人力资源
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet,Route("find")]
        public IActionResult find(int id)
        {
            return Ok(_product.find(id));
        }
        /// <summary>
        /// 员工录入核定表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("finde")]
        public IActionResult finde(int id)
        {
            return Ok(_product.staff(id));
        }
        /// <summary>
        /// 离职交接
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("findea")]
        public IActionResult findea(int id)
        {
            return Ok(_product.bPMSys(id));
        }

        /// <summary>
        /// 离职流程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("findet")]
        public IActionResult findet(int id)
        {
            return Ok(_product.departure(id));
        }
        /// <summary>
        /// 年度基础信息表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("findeta")]
        public IActionResult findeta(int id)
        {
            return Ok(_product.information(id));
        }
        /// <summary>
        /// 年度详情信息表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("findetat")]
        public IActionResult findetat(int id)
        {
            return Ok(_product.annual_Details(id));
        }
        /// <summary>
        /// 员工亲属详细信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("findetata")]
        public IActionResult findetata(int id)
        {
            return Ok(_product.relative(id));
        }

    }
}
