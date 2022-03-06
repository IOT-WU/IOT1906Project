using AutoMapper;
using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using IRepository;
using IServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class UserServices : IUserServices
    {
        private readonly IRepositoryDB<BPMSysUsers> repositoryLogin;
        private readonly IRepositoryDB<BPMInstTasks> repositoryTask;
        private readonly IRepositoryDB<BPMInstProcSteps> repositoryPro;
        //private readonly IMapper mapper;
        public UserServices(IRepositoryDB<BPMSysUsers> repositoryLogin, IRepositoryDB<BPMInstProcSteps> repositoryPro, IRepositoryDB<BPMInstTasks> repositoryTask/*, IMapper mapper*/)
        {
            this.repositoryLogin = repositoryLogin;
            this.repositoryPro = repositoryPro;
            this.repositoryTask = repositoryTask;
            //this.mapper = mapper;
        }
        /// <summary>
        /// 获取正在审核的流程
        /// </summary>
        /// <returns></returns>
        public ResultOutPutModels<List<OutPutOwnerProcess>> GetRunningProcess(string account, int pageindex, int pagesize)
        {
            //获取数据库数据
            var Prolist = repositoryPro.QueryList(x => x.TaskID.Equals(x.TaskID));
            var Tasklist = repositoryTask.QueryList(x => x.TaskID.Equals(x.TaskID));
            //实例化结果输出类
            ResultOutPutModels<List<OutPutOwnerProcess>> result = new ResultOutPutModels<List<OutPutOwnerProcess>>();
            var list = (from a in Tasklist
                        join b in Prolist on a.TaskID equals b.TaskID
                        where a.State == "Running   " && b.FinishAt is null && b.OwnerAccount == account
                        select new OutPutOwnerProcess
                        {
                            Key = a.TaskID,
                            SerialNum = a.SerialNum,
                            ProcessName = a.ProcessName,
                            OwnerAccount = a.OwnerAccount,
                            CreateAt = a.CreateAt,
                            NodeName = b.NodeName,
                            TaskID = a.TaskID,
                            StepID = b.StepID,
                            State = a.State,
                            NodeOwnerAccount = b.OwnerAccount,
                        }).ToList();
            list = list.Where(x => x.NodeName != "开始").ToList();
            //分页
            result.Code = "200";
            result.Msg = "OK";
            result.Total = list.Count;
            result.Result = list.OrderByDescending(x => x.Key).Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();

            return result;
        }
        /// <summary>
        /// 获取已处理的流程
        /// </summary>
        /// <returns></returns>
        public ResultOutPutModels<List<OutPutOwnerProcess>> GetDisposeProcess(string account, int pageindex, int pagesize)
        {
            //获取数据库数据
            var Prolist = repositoryPro.QueryList(x => x.TaskID.Equals(x.TaskID));
            var Tasklist = repositoryTask.QueryList(x => x.TaskID.Equals(x.TaskID));
            //实例化结果输出类
            ResultOutPutModels<List<OutPutOwnerProcess>> result = new ResultOutPutModels<List<OutPutOwnerProcess>>();
            var list = (from a in Tasklist
                        join b in Prolist on a.TaskID equals b.TaskID
                        where a.State != "Running   " && b.FinishAt is not null && b.OwnerAccount == account
                        select new OutPutOwnerProcess
                        {
                            Key = a.TaskID,
                            SerialNum = a.SerialNum,
                            ProcessName = a.ProcessName,
                            OwnerAccount = a.OwnerAccount,
                            CreateAt = a.CreateAt,
                            NodeName = b.NodeName,
                            TaskID = a.TaskID,
                            StepID = b.StepID,
                            State = a.State,
                            NodeOwnerAccount = b.OwnerAccount,
                        }).ToList();
            //分页Approved  
            result.Code = "200";
            result.Msg = "OK";
            result.Total = list.Count;
            result.Result = list.OrderByDescending(x => x.Key).Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();

            return result;
        }
        /// <summary>
        /// 获取已结束的流程
        /// </summary>
        /// <returns></returns>
        public ResultOutPutModels<List<OutPutOwnerProcess>> GetEndProcess(string account, int pageindex, int pagesize)
        {
            //获取数据库数据
            var Prolist = repositoryPro.QueryList(x => x.TaskID.Equals(x.TaskID));
            var Tasklist = repositoryTask.QueryList(x => x.TaskID.Equals(x.TaskID));
            //实例化结果输出类
            ResultOutPutModels<List<OutPutOwnerProcess>> result = new ResultOutPutModels<List<OutPutOwnerProcess>>();
            var list = (from a in Tasklist
                        join b in Prolist on a.TaskID equals b.TaskID
                        where a.State == "Approved  " && b.FinishAt is not null && b.OwnerAccount == account
                        select new OutPutOwnerProcess
                        {
                            Key = a.TaskID,
                            SerialNum = a.SerialNum,
                            ProcessName = a.ProcessName,
                            OwnerAccount = a.OwnerAccount,
                            CreateAt = a.CreateAt,
                            NodeName = b.NodeName,
                            TaskID = a.TaskID,
                            StepID = b.StepID,
                            State = a.State,
                            NodeOwnerAccount = b.OwnerAccount,
                        }).ToList();
            //分页
            result.Code = "200";
            result.Msg = "OK";
            result.Total = list.Count;
            result.Result = list.OrderByDescending(x => x.Key).Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();

            return result;
        }
        /// <summary>
        /// 获取自己的流程
        /// </summary>
        /// <returns></returns>
        public ResultOutPutModels<List<OutPutOwnerProcess>> GetMyProcess(string account, int pageindex, int pagesize)
        {
            //获取数据库数据
            var Prolist = repositoryPro.QueryList(x => x.TaskID.Equals(x.TaskID));
            var Tasklist = repositoryTask.QueryList(x => x.TaskID.Equals(x.TaskID));
            //实例化结果输出类
            ResultOutPutModels<List<OutPutOwnerProcess>> result = new ResultOutPutModels<List<OutPutOwnerProcess>>();
            var list = (from a in Tasklist
                        where a.OwnerAccount == account
                        select new OutPutOwnerProcess
                        {
                            Key = a.TaskID,
                            SerialNum = a.SerialNum,
                            ProcessName = a.ProcessName,
                            OwnerAccount = a.OwnerAccount,
                            CreateAt = a.CreateAt,
                            TaskID = a.TaskID,
                            State = a.State,
                            NodeOwnerAccount = a.OwnerAccount,
                        }).ToList();
            //分页
            result.Code = "200";
            result.Msg = "OK";
            result.Total = list.Count;
            result.Result = list.OrderByDescending(x => x.Key).Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();

            return result;
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

        /// <summary>
        /// 获取所有流程
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<OutPutOwnerProcess> GetAllProcess()
        {
            //获取数据库数据
            var Prolist = repositoryPro.QueryList(x => x.TaskID.Equals(x.TaskID));
            var Tasklist = repositoryTask.QueryList(x => x.TaskID.Equals(x.TaskID));
            //实例化结果输出类
            ResultOutPutModels<List<OutPutOwnerProcess>> result = new ResultOutPutModels<List<OutPutOwnerProcess>>();
            var list = (from a in Tasklist
                        join b in Prolist on a.TaskID equals b.TaskID
                        where b.OwnerAccount != null
                        select new OutPutOwnerProcess
                        {
                            Key = a.TaskID,
                            SerialNum = a.SerialNum,
                            ProcessName = a.ProcessName,
                            OwnerAccount = a.OwnerAccount,
                            CreateAt = a.CreateAt,
                            NodeName = b.NodeName,
                            TaskID = a.TaskID,
                            StepID = b.StepID,
                            State = a.State,
                            NodeOwnerAccount = b.OwnerAccount,
                        }).ToList();

            return list;
        }
    }
}
