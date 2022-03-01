using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{

    /// <summary>
    /// 用户信息表（登录）
    /// </summary>
    public class BPMSysUsers
    {
        [Key]
        public string Account { get; set; }
        public string Password { get; set; }
        public bool SysUser { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string HRID { get; set; }
        public DateTime DateHired { get; set; }
        public string Office { get; set; }
        public string CostCenter { get; set; }
        public string OfficePhone { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string EMail { get; set; }
        public string WWWHomePage { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public int UserLevel { get; set; }
        public string 家庭电话 { get; set; }
        public string SID { get; set; }
        public string LogonProvider { get; set; }
        public bool Disabled { get; set; }
        public string NameSpell { get; set; }
    }
}
