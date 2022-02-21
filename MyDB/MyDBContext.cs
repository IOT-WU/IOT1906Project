using DomainDTO.EFModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace MyDB
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public DbSet<UserLoginEFModels> UserLogin { get; set; } //用户登录类
    }
}
