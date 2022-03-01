using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    /// <summary>
    /// 员工离职面谈表
    /// </summary>
    public class ExitInterview
    {
        public int Id { get; set; }
        /// <summary>
        /// 制表人
        /// </summary>
        public string Exit_lister { get; set; }
        /// <summary>
        /// 制表部门
        /// </summary>
        public string Exit_Demt { get; set; }
        /// <summary>
        /// 制表日期
        /// </summary>
        public string Exit_Data { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Exit_StaffName { get; set; }
        /// <summary>
        /// 员工工号
        /// </summary>
        public string Exit_StaffID { get; set; }
        /// <summary>
        /// 所在部门
        /// </summary>
        public string Exit_Department { get; set; }
        /// <summary>
        /// 岗位
        /// </summary>
        public string Exit_Job { get; set; }
        /// <summary>
        /// 入职日期
        /// </summary>
        public string Exit_EntryData { get; set; }
        /// <summary>
        /// 离职日期
        /// </summary>
        public string Exit_LeaveData { get; set; }
        /// <summary>
        /// 劳动合同终止类型
        /// </summary>
        public string Exit_TermType { get; set; }
        /// <summary>
        /// 劳动合同终止原因
        /// </summary>
        public string Exit_TermCause { get; set; }
        /// <summary>
        /// 离职原因
        /// </summary>
        public string Exit_LeaveCause { get; set; }
        /// <summary>
        /// 面读记录
        /// </summary>
        public string Exit_InterviewRecord { get; set; }
        //员工评价内容详细信息
        /// <summary>
        /// 薪资和福利
        /// </summary>
        public string Exit_SalaryAndBenefits { get; set; }
        /// <summary>
        /// 培训发展
        /// </summary>
        public string Exit_TrainingAndDevelopment { get; set; }
        /// <summary>
        /// 提升前景
        /// </summary>
        public string Exit_PromotionProspects { get; set; }
        /// <summary>
        /// 公司管理
        /// </summary>
        public string Exit_CompanyManagement { get; set; }
        /// <summary>
        /// 奖励和认可
        /// </summary>
        public string Exit_AwardsAndRecognition { get; set; }
        /// <summary>
        /// 沟通渠道
        /// </summary>
        public string Exit_CommunicationChannels { get; set; }
        /// <summary>
        /// 工作满意度
        /// </summary>
        public string Exit_JobSatisfaction { get; set; }
        /// <summary>
        /// 员工和经理沟通
        /// </summary>
        public string Exit_CommunicationWithManager { get; set; }
        /// <summary>
        /// 是否愿意被公司重新聘佣
        /// </summary>
        public string Exit_IsHire { get; set; }
    }
}
