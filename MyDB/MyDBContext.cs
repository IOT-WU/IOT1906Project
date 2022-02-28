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
    }
}
