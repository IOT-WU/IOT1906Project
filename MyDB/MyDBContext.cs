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
        public DbSet<BPMSysOUs> BPMSysOUs { get; set; } //部门信息表
        public DbSet<LeaveType> LeaveType { get; set; } //请假流程申请表
        public DbSet<Departure> Departure { get; set; } //离职流程申请表
        public DbSet<Employe> Employe { get; set; } //员工录用基础表
        public  DbSet<Relati> Relati { get; set; } //员工亲属表
        public DbSet<Fixedasse> Fixedasse { get; set; } //固定资产申请流程表
        public DbSet<Handover> Handover { get; set; } //固定资产交接流程表
        public DbSet<Borrow> Borrow { get; set; } //固定资产借用流程表
        public DbSet<Sacceptance> Sacceptance { get; set; } //固定资产验收基础表
        public DbSet<Accdetailed> Accdetailed { get; set; } //固定资产验收详细信息表
        public DbSet<Attachment> Attachment { get; set; } //固定资产附件信息表
        public DbSet<BPMSysOURoles> BPMSysOURoles { get; set; } //角色表


    }
}
