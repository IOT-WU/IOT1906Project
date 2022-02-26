using DomainDTO.EFModels;
using DomainDTO.InPutModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace MyDB
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
<<<<<<< HEAD
        public  DbSet<Leave> Leave { get; set; } //请假流程申请表
        public virtual DbSet<BPMSysUsers> BPMSysUsers { get; set; } //用户信息表
=======
        public virtual DbSet<Leave> Leave { get; set; } //请假流程申请表
        //public virtual DbSet<BPMSysUsers> BPMSysUsers { get; set; } //用户信息表
>>>>>>> 8865f63ee236a09a104276881b1c53235410ade6
    }
}
