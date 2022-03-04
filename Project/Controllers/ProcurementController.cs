using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    /// <summary>
    /// 采购控制器
    /// </summary>
    [ApiController]
    public class ProcurementController : ControllerBase
    {
        private readonly IProcurementServices services;
        public ProcurementController(IProcurementServices services)
        {
            this.services = services;
        }
        /// <summary>
        /// 采购显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetProcurementDetails")]
        public IActionResult GetProcurementDetails(string Name)
        {
            return Ok(services.GetProcurement(Name));
        }
    }
}
