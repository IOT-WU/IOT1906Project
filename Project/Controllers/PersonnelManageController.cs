using DomainDTO.EFModels;
using IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [ApiController]
    public class PersonnelManageController : ControllerBase
    {
        private readonly IAnnualServices AnnualServices;

        public PersonnelManageController(IAnnualServices AnnualServices)
        {
            this.AnnualServices = AnnualServices;
        }

        /// <summary>
        /// 年度招聘添加
        /// </summary>
        /// <param name="information"></param>
        /// <returns></returns>
        [HttpPost, Route("api/Annualadd")]
        public IActionResult Annualadd([FromBody] Annual_information information)
        {
            var list = AnnualServices.Annual_add(information);
            return Ok(list);
        }
    }
}