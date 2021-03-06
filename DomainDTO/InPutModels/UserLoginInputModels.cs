using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.InPutModels
{
    /// <summary>
    /// 用户登录类
    /// </summary>
    public class UserLoginInputModels
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPass { get; set; }
    }
}
