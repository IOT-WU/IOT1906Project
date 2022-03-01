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
        public  DbSet<BPMSysUsers> BPMSysUsers { get; set; } //用户信息表
        public  DbSet<LeaveType> LeaveType { get; set; } //请假流程申请表
        public  DbSet<Departure> Departure { get; set; } //离职流程申请表
        public  DbSet<DeparturetTransfer> DeparturetTransfer { get; set; } //离职交接申请表
        public  DbSet<CarApplication> CarApplication { get; set; } //用车申请表
        public  DbSet<ExitInterview> ExitInterview { get; set; } //员工离职面谈表
    }
}
