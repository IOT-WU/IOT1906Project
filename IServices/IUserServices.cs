using DomainDTO.EFModels;
using DomainDTO.InPutModels;
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
        BPMSysUsers UserLogin(UserLoginInputModels model);
        
    }
}
