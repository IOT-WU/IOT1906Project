using AutoMapper;
using DomainDTO.EFModels;
using IRepository;
using IServices;
using System;

namespace Services
{
    public class UserServices : IUserServices
    {
        private readonly IRepositoryDB<UserLoginEFModels> repositoryLogin;
        private readonly IMapper mapper;
        public UserServices(IRepositoryDB<UserLoginEFModels> repositoryLogin, IMapper mapper)
        {
            this.repositoryLogin = repositoryLogin;
            this.mapper = mapper;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserLoginEFModels UserLogin(UserLoginEFModels model)
        {
            var obj = repositoryLogin.GetModel(x => x.UserName.Equals(model.UserName) & x.UserPass.Equals(model.UserPass));
            return obj;
        }
    }
}
