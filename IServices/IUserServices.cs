using DomainDTO.EFModels;
using System;

namespace IServices
{
    public interface IUserServices
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        UserLoginEFModels UserLogin(UserLoginEFModels model);
    }
}
