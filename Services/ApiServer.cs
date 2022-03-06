using DomainDTO.EFModels;
using IRepository;
using IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class ApiServer :IProductService
    {
        readonly IRepositoryDB<Maintain> _product;
        readonly IRepositoryDB<MInsurance> _minsurance;
        readonly IRepositoryDB<Mrepair> _mrpair;
        readonly IRepositoryDB<MViolation> _mviolation;
        readonly IRepositoryDB<Resources> _resources;
        readonly IRepositoryDB<Employe> _employed;
        readonly IRepositoryDB<DeparturetTransfer> _departuretransfer;
        readonly IRepositoryDB<Departure> _departure;
        readonly IRepositoryDB<Annual_information> _information;
        readonly IRepositoryDB<Annual_details> _details;
        readonly IRepositoryDB<Relati> _relatve;
        readonly IRepositoryDB<Leave> _leave;
        readonly IRepositoryDB<ExitInterview> _Exception;
        readonly IRepositoryDB<Announcement_information> _Announcement;
        readonly IRepositoryDB<File_information> _File;
        public ApiServer(IRepositoryDB<Maintain> product, IRepositoryDB<MInsurance> minsurance, IRepositoryDB<Mrepair> mrpair, IRepositoryDB<MViolation> mviolation, IRepositoryDB<Resources> resources, IRepositoryDB<Employe> employed, IRepositoryDB<DeparturetTransfer> departuretransfer, IRepositoryDB<Departure> departure, IRepositoryDB<Annual_information> information, IRepositoryDB<Annual_details> details, IRepositoryDB<Relati> relatve, IRepositoryDB<Leave> leave,IRepositoryDB<ExitInterview> Exception, IRepositoryDB<Announcement_information> Announcement, IRepositoryDB<File_information> File)
        {
            _product = product;
            _minsurance = minsurance;
            _mrpair = mrpair;
            _mviolation = mviolation;
            _resources = resources;
            _employed = employed;
            _departuretransfer = departuretransfer;
            _leave = leave;
            _departure = departure;
            _details = details;
            _information = information;
            _relatve = relatve;
            _Exception = Exception;
            _Announcement = Announcement;
            _File = File;
        }
        /// <summary>
        /// 车辆保险
        /// </summary>
        /// <param name="maintain"></param>
        /// <returns></returns>
        public int Adder1(Maintain maintain)
        {
            return _product.ExecuteAdd(maintain);
        }
        /// <summary>
        /// 车辆保养
        /// </summary>
        /// <param name="mInsurancea"></param>
        /// <returns></returns>
        public int Adder2(MInsurance mInsurancea)
        {
            return _minsurance.ExecuteAdd(mInsurancea);
        }
        /// <summary>
        /// 车辆维修
        /// </summary>
        /// <param name="mrepair"></param>
        /// <returns></returns>
        public int Adder3(Mrepair mrepair)
        {
            return _mrpair.ExecuteAdd(mrepair);
        }
        /// <summary>
        /// 车辆违章
        /// </summary>
        /// <param name="mViolation"></param>
        /// <returns></returns>
        public int Adder4(MViolation mViolation)
        {
            return _mviolation.ExecuteAdd(mViolation);
        }
        /// <summary>
        /// 人力资源反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Resources find(int id)
        {
            return _resources.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 员工录入核定表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employe staff(int id)
        {
            return _employed.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 离职交接
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DeparturetTransfer bPMSys(int id)
        {
            return _departuretransfer.GetModel(a => a.TaskId.Equals(id));
        }
       

        /// <summary>
        /// 年度基础信息表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Annual_information information(int id)
        {
            return _information.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 离职流程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Departure departure(int id)
        {
            return _departure.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 年度详情信息表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Annual_details annual_Details(int id)
        {
            return _details.GetModel(a => a.TaskId.Equals(id));
        }
       

        /// <summary>
        /// 请假申请表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Leave leave(int id)
        {
            return _leave.GetModel(a => a.TaskId.Equals(id));
        }

        /// <summary>
        /// 员工面谈添加方法
        /// </summary>
        /// <param name="Interview"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetExitInterviewadd(ExitInterview Interview)
        {
            return _Exception.ExecuteAdd(Interview);
        }

        /// <summary>
        /// 公告基本表添加方法
        /// </summary>
        /// <param name="Announcement"></param>
        /// <returns></returns>
        public int GetAnnouncementadd(Announcement_information Announcement)
        {
            return _Announcement.ExecuteAdd(Announcement);
        }

        /// <summary>
        /// 文件管理表添加方法
        /// </summary>
        /// <param name="File"></param>
        /// <returns></returns>
        public int GetFileadd(File_information File)
        {
            return _File.ExecuteAdd(File);
        }
    }
}
