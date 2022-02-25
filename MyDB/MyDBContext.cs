using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace MyDB
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public virtual DbSet<Leave> Leave { get; set; } //请假流程申请表
        public virtual DbSet<BPMSysUsers> BPMSysUsers { get; set; } //用户信息表
        public virtual DbSet<Employed> Employed { get; set; } //员工录入核定表
        public virtual DbSet<Relative> Relative { get; set; } //员工亲属信息表
    }
}
