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
        public DbSet<Employed> Employed { get; set; }
        public  DbSet<LeaveType> LeaveType { get; set; } //请假流程申请表
        public  DbSet<Departure> Departure { get; set; } //离职流程申请表
        public DbSet<Resources> Resources { get; set; } //离职流程申请表
        public DbSet<Maintain> maintains { get; set; }//车辆保养记录表
        public DbSet<MInsurance> mInsurances { get; set; }//车辆保险纪录表
        public DbSet<Mrepair> mrepairs { get; set; }//车辆维修记录表
        public DbSet<MViolation> mViolations { get; set; }//车辆违章记录
    }
}
