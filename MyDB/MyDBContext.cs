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
        public virtual DbSet<Employe> Employe { get; set; } //员工录用基础表
        public virtual DbSet<Relati> Relati { get; set; } //员工亲属表
       
    }
}
