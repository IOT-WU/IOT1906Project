using DomainDTO.EFModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace MyDB
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public virtual DbSet<UserLoginEFModels> UserLogin { get; set; } //用户登录类
        public virtual DbSet<LeaveEFModels> Leave { get; set; } //请假流程申请表
    }
}
