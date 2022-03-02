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
        [HttpPost,Route("api/Adder1")]
       
        public IActionResult Adder1([FromBody]Maintain maintain)
        {
            return Ok(_product.Adder1(maintain));
        }
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
        [HttpGet,Route("find")]
        public IActionResult find(int id)
        {
            return Ok(_product.find(id));
        }
        [HttpGet, Route("finde")]
        public IActionResult finde(int id)
        {
            return Ok(_product.staff(id));
        }
    }
}
