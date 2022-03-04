using DomainDTO.EFModels;
using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
       
        private IEmpServices iempServices;
        public EmpController(IEmpServices iempServices)
        {
          
            this.iempServices = iempServices;
        }
        /// <summary>
        /// 员工录用单个信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost,Route("api/GetEmp")]
        public IActionResult GetEmp(int id)
        {
            return Ok(iempServices.GetEmploye(id));
        }
        /// <summary>
        /// 员工亲属单个信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, Route("api/GetReti")]
        public IActionResult GetReti(int id)
        {
            return Ok(iempServices.GetRelati(id));
        }
    }
}
