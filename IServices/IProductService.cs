using DomainDTO.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
   public interface IProductService
    {
        /// <summary>
        /// 车辆保养记录表
        /// </summary>
        /// <param name="maintain"></param>
        /// <returns></returns>
        public int Adder1(Maintain maintain);
        /// <summary>
        /// 车辆保险纪录表
        /// </summary>
        /// <param name="mInsurance"></param>
        /// <returns></returns>
        public int Adder2(MInsurance mInsurance);
        /// <summary>
        /// 车辆维修记录表
        /// </summary>
        /// <param name="mrepair"></param>
        /// <returns></returns>
        public int Adder3(Mrepair mrepair);
        /// <summary>
        /// 车辆违章记录
        /// </summary>
        /// <param name="mViolation"></param>
        /// <returns></returns>
        public int Adder4(MViolation mViolation);
        /// <summary>
        /// 反填人力资源表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Resources find(int id);
     
        /// <summary>
        /// 离职交接
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeparturetTransfer bPMSys(int id);
        /// <summary>
        /// 离职流程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Departure departure(int id);
        /// <summary>
        /// 年度基础信息表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Annual_information information(int id);
        /// <summary>
        /// 年度详情信息表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Annual_details annual_Details(int id);
      
        /// <summary>
        /// 请假申请表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Leave leave(int id);

        /// <summary>
        /// 员工面谈添加接口
        /// </summary>
        /// <param name="annual"></param>
        /// <returns></returns>
        int GetExitInterviewadd(ExitInterview Interview);

        /// <summary>
        /// 公告基本信息添加接口
        /// </summary>
        /// <param name="annual"></param>
        /// <returns></returns>
        int GetAnnouncementadd(Announcement_information Announcement);

        /// <summary>
        /// 文件管理表添加接口
        /// </summary>
        /// <param name="annual"></param>
        /// <returns></returns>
        int GetFileadd(File_information File);
        /// <summary>
        /// 固定资产交接表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Handover GetHandover(int id);
        /// <summary>
        /// 用章基础信息表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Chapter_information chapter(int id);
        /// <summary>
        /// 资产验收详细表
        /// </summary>
        /// <returns></returns>
        public Accdetailed Gitaccdetailed(int id);
    }
}
