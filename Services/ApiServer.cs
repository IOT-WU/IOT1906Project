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
        readonly IRepositoryDB<Handover> _handover;
        readonly IRepositoryDB<Chapter_information> _chapter;
        readonly IRepositoryDB<Accdetailed> _accdetaild;
        readonly IRepositoryDB<Borrow> _borrow;
        readonly IRepositoryDB<ReceptionTripDetails> _receptiontripdetails;
        readonly IRepositoryDB<Sacceptance> _sacceptance;
        readonly IRepositoryDB<ReceptionItemsDetails> _receptionitemsdetails;
        readonly IRepositoryDB<ProcurementDetails> _procurementDetails;
        readonly IRepositoryDB<Procurement> _procurement;
        readonly IRepositoryDB<Prints_information> _prints_information;
        readonly IRepositoryDB<Fixedasse> _fixedasse;
        readonly IRepositoryDB<CarApplication> _carapplicarion;
        public ApiServer(IRepositoryDB<Maintain> product, IRepositoryDB<MInsurance> minsurance, IRepositoryDB<Mrepair> mrpair, IRepositoryDB<MViolation> mviolation, IRepositoryDB<Resources> resources, IRepositoryDB<Employe> employed, IRepositoryDB<DeparturetTransfer> departuretransfer, IRepositoryDB<Departure> departure, IRepositoryDB<Annual_information> information, IRepositoryDB<Annual_details> details, IRepositoryDB<Relati> relatve, IRepositoryDB<Leave> leave,IRepositoryDB<ExitInterview> Exception, IRepositoryDB<Announcement_information> Announcement, IRepositoryDB<File_information> File, IRepositoryDB<Handover> handover, IRepositoryDB<Chapter_information> chapter, IRepositoryDB<Accdetailed> accdetaild, IRepositoryDB<Borrow> borrow, IRepositoryDB<ReceptionTripDetails> receptiontripdetails, IRepositoryDB<Sacceptance> sacceptance, IRepositoryDB<ReceptionItemsDetails> receptionitemsdetails, IRepositoryDB<ProcurementDetails> procurementDetails, IRepositoryDB<Procurement> procurement, IRepositoryDB<Prints_information> prints_information, IRepositoryDB<Fixedasse> fixedasse, IRepositoryDB<CarApplication> carapplicarion)
        {
            _procurement = procurement;
            _receptiontripdetails = receptiontripdetails;
            _product = product;
            _minsurance = minsurance;
            _handover = handover;
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
            _chapter = chapter;
            _accdetaild = accdetaild;
            _borrow = borrow;
            _receptionitemsdetails = receptionitemsdetails;
            _procurementDetails = procurementDetails;
            _prints_information = prints_information;
            _carapplicarion = carapplicarion;
        }
        /// <summary>
        /// 车辆保险添加
        /// </summary>
        /// <param name="maintain"></param>
        /// <returns></returns>
        public int Adder1(Maintain maintain)
        {
            return _product.ExecuteAdd(maintain);
        }
        /// <summary>
        /// 车辆保养添加
        /// </summary>
        /// <param name="mInsurancea"></param>
        /// <returns></returns>
        public int Adder2(MInsurance mInsurancea)
        {
            return _minsurance.ExecuteAdd(mInsurancea);
        }
        /// <summary>
        /// 车辆维修添加
        /// </summary>
        /// <param name="mrepair"></param>
        /// <returns></returns>
        public int Adder3(Mrepair mrepair)
        {
            return _mrpair.ExecuteAdd(mrepair);
        }
        /// <summary>
        /// 车辆违章添加
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
        /// <summary>
        /// 固定资产交接表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Handover GetHandover(int id)
        {
           return _handover.GetModel(a=>a.TaskId.Equals(id));
        }
        /// <summary>
        /// 用章基础信息表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Chapter_information chapter(int id)
        {
            return _chapter.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 资产验收详细表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Accdetailed Gitaccdetailed(int id)
        {
            return _accdetaild.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 固定资产资料借用单表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Borrow Gitborrow(int id)
        {
            return _borrow.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 车辆保险编辑
        /// </summary>
        /// <param name="maintain"></param>
        /// <returns></returns>
        public int EditMaintain(Maintain maintain)
        {
            return _product.ExecuteUpd(maintain);
        }
        /// <summary>
        /// 车辆保养编辑
        /// </summary>
        /// <param name="mInsurance"></param>
        /// <returns></returns>
        public int EditMInsurance(MInsurance mInsurance)
        {
            return _minsurance.ExecuteUpd(mInsurance);
        }
        /// <summary>
        /// 车辆维修编辑
        /// </summary>
        /// <param name="mrepair"></param>
        /// <returns></returns>
        public int EditMrepair(Mrepair mrepair)
        {
            return _mrpair.ExecuteUpd(mrepair);
        }
        /// <summary>
        /// 车辆违章编辑
        /// </summary>
        /// <param name="mViolation"></param>
        /// <returns></returns>
        public int EditMViolation(MViolation mViolation)
        {
            return _mviolation.ExecuteUpd(mViolation);
        }
        /// <summary>
        /// 接待申请行程详情表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ReceptionTripDetails GetReceptionTripDetails(int id)
        {
           return  _receptiontripdetails.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 固定资产验收基础表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sacceptance GetSacceptance(int id)
        {
            return _sacceptance.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 接待申请物品详情表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ReceptionItemsDetails GetReceptionItemsDetails(int id)
        {
            return _receptionitemsdetails.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 日常用品采购详情表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProcurementDetails GetprocurementDetails(int id)
        {
            return _procurementDetails.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 日常用品采购表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Procurement GetProcurement(int id)
        {
            return _procurement.GetModel(a=>a.Equals(id));
        }
        /// <summary>
        /// 刻章申请表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Prints_information GetPrints_Information(int id)
        {
            return _prints_information.GetModel(a => a.TaskId.Equals(id));
        }
        /// <summary>
        /// 固定资产申请单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Fixedasse GetFixedasse(int id)
        {
            return _fixedasse.GetModel(a=>a.TaskId.Equals(id));
        }
        /// <summary>
        /// 用车申请表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CarApplication GetCarApplication(int id)
        {
            return _carapplicarion.GetModel(a => a.TaskId.Equals(id));
        }
    }
}
