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
        public virtual DbSet<Annual_information> Annual_information { get; set; } //年度基础信息表
        public virtual DbSet<Annual_details> Annual_details { get; set; } //年度详情信息表

        public virtual DbSet<Chapter_information> Chapter_information { get; set; } //用章申请表
        public virtual DbSet<Prints_information> Prints_information { get; set; } //刻章申请表
        public virtual DbSet<Announcement_information> Announcement_information { get; set; } //公告基本信息表
        public virtual DbSet<File_information> File_information { get; set; } //文件管理表

    }
}
