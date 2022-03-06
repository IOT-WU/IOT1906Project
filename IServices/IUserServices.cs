using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using System;
using System.Collections.Generic;

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
        ResultOutPutModels<List<OutPutOwnerProcess>> GetRunningProcess(string account, int pageindex, int pagesize);
        ResultOutPutModels<List<OutPutOwnerProcess>> GetDisposeProcess(string account, int pageindex, int pagesize);
        ResultOutPutModels<List<OutPutOwnerProcess>> GetMyProcess(string account, int pageindex, int pagesize);
        ResultOutPutModels<List<OutPutOwnerProcess>> GetEndProcess(string account, int pageindex, int pagesize);
        List<OutPutOwnerProcess> GetAllProcess();

    }
}
