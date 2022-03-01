using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace MyDB
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public  DbSet<Leave> Leave{ get; set; } //请假流程申请表
        public virtual DbSet<BPMSysUsers> BPMSysUsers { get; set; } //用户信息表
        public  DbSet<LeaveType> LeaveType { get; set; } //请假流程申请表
        public  DbSet<Departure> Departure { get; set; } //离职流程申请表
        public  DbSet<Procurement> Procurement { get; set; } //日常用品采购申请表
        public  DbSet<ProcurementDetails> ProcurementDetails { get; set; } //日常用品采购申请详细表
        public  DbSet<Reception> Reception { get; set; } //接待申请表
        public  DbSet<ReceptionItemsDetails> ReceptionItemsDetails { get; set; } //接待申请物品详细表
        public  DbSet<ReceptionTripDetails> ReceptionTripDetails { get; set; } //接待申请行程详细表
        public  DbSet<MeetingRoomNew> MeetingRoomNew { get; set; } //会议室新增表
        public  DbSet<ReservationMeetingRoom> ReservationMeetingRoom { get; set; } //预定会议室表
    }
}
