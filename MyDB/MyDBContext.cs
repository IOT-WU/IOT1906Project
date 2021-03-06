using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace MyDB
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }


        public DbSet<Leave> Leave { get; set; } //请假流程申请表
        public DbSet<BPMSysUsers> BPMSysUsers { get; set; } //用户信息表
        public DbSet<BPMInstTasks> BPMInstTasks { get; set; } //流程表
        public DbSet<BPMInstProcSteps> BPMInstProcSteps { get; set; } //流程状态表
        public DbSet<Annual_information> Annual_information { get; set; } //年度基础信息表
        public DbSet<Annual_details> Annual_details { get; set; } //年度详情信息表
        public DbSet<Chapter_information> Chapter_information { get; set; } //用章申请表
        public DbSet<Prints_information> Prints_information { get; set; } //刻章申请表
        public DbSet<Announcement_information> Announcement_information { get; set; } //公告基本信息表
        public DbSet<File_information> File_information { get; set; } //文件管理表
        public  DbSet<LeaveType> LeaveType { get; set; } //请假流程申请表
        public  DbSet<Departure> Departure { get; set; } //离职流程申请表
        public  DbSet<DeparturetTransfer> DeparturetTransfer { get; set; } //离职交接申请表
        public  DbSet<CarApplication> CarApplication { get; set; } //用车申请表
        public  DbSet<ExitInterview> ExitInterview { get; set; } //员工离职面谈表
        public  DbSet<Procurement> Procurement { get; set; } //日常用品采购申请表
        public  DbSet<ProcurementDetails> ProcurementDetails { get; set; } //日常用品采购申请详细表
        public  DbSet<Reception> Reception { get; set; } //接待申请表
        public DbSet<Employe> employeds { get; set; } //员工录入核定
        public DbSet<Relati> relatis { get; set; } //员工亲属详细信息
        public  DbSet<ReceptionItemsDetails> ReceptionItemsDetails { get; set; } //接待申请物品详细表
        public  DbSet<ReceptionTripDetails> ReceptionTripDetails { get; set; } //接待申请行程详细表
        public  DbSet<MeetingRoomNew> MeetingRoomNew { get; set; } //会议室新增表
        public  DbSet<ReservationMeetingRoom> ReservationMeetingRoom { get; set; } //预定会议室表
        public  DbSet<Annual_Leavetable> Annual_Leavetable { get; set; } //年度假期表
        public DbSet<Resources> Resources { get; set; } //离职流程申请表
        public DbSet<Maintain> maintains { get; set; }//车辆保养记录表
        public DbSet<MInsurance> mInsurances { get; set; }//车辆保险纪录表
        public DbSet<Mrepair> mrepairs { get; set; }//车辆维修记录表
        public DbSet<MViolation> mViolations { get; set; }//车辆违章记录



        public DbSet<BPMSysOUs> BPMSysOUs { get; set; } //部门信息表
        public DbSet<Employe> Employe { get; set; } //员工录用基础表
        public  DbSet<Relati> Relati { get; set; } //员工亲属表
        public DbSet<Fixedasse> Fixedasse { get; set; } //固定资产申请流程表
        public DbSet<Handover> Handover { get; set; } //固定资产交接流程表
        public DbSet<Borrow> Borrow { get; set; } //固定资产借用流程表
        public DbSet<Sacceptance> Sacceptance { get; set; } //固定资产验收基础表
        public DbSet<Accdetailed> Accdetailed { get; set; } //固定资产验收详细信息表
        public DbSet<Attachment> Attachment { get; set; } //固定资产附件信息表
        public DbSet<BPMSysOURoles> BPMSysOURoles { get; set; } //角色


    }
}
