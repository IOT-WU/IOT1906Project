using System;
using System.Collections.Generic;
using DomainDTO.EFModels;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServices;
using IRepository;

namespace Services
{
    public class AnnualServices : IAnnualServices
    {
        private readonly IRepositoryDB<Annual_information> _informationDB;

        public AnnualServices(IRepositoryDB<Annual_information> informationDB)
        {
            this._informationDB = informationDB;
        }

        /// <summary>
        /// 年度基础信息表添加方法
        /// </summary>
        /// <param name="_information"></param>
        /// <returns></returns>
        public int Annual_add(Annual_information _information)
        {
            return _informationDB.ExecuteAdd(_information);
        }
    }
}
