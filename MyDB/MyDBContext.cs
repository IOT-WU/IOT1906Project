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
        public  DbSet<ReceptionItemsDetails> ReceptionItemsDetails { get; set; } //接待申请物品详细表
        public  DbSet<ReceptionTripDetails> ReceptionTripDetails { get; set; } //接待申请行程详细表
        public  DbSet<MeetingRoomNew> MeetingRoomNew { get; set; } //会议室新增表
        public  DbSet<ReservationMeetingRoom> ReservationMeetingRoom { get; set; } //预定会议室表
    }
}
