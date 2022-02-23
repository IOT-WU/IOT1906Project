using AutoMapper;
using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using IRepository;
using IServices;
using System;

namespace Services
{
    public class UserServices : IUserServices
    {
        private readonly IRepositoryDB<BPMSysUsers> repositoryLogin;
        //private readonly IMapper mapper;
        public UserServices(IRepositoryDB<BPMSysUsers> repositoryLogin/*, IMapper mapper*/)
        {
            this.repositoryLogin = repositoryLogin;
            //this.mapper = mapper;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BPMSysUsers UserLogin(UserLoginInputModels model)
        {
            var obj = repositoryLogin.GetModel(x => x.Account.Equals(model.UserName) & x.Password.Equals(model.UserPass));
            return obj;
        }
    }
}
