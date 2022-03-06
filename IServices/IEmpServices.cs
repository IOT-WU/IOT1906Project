using DomainDTO.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    public interface IEmpServices
    {
        /// <summary>
        /// 获取部门
        /// </summary>
        /// <returns></returns>
        List<BPMSysOUs> Bind();
        /// <summary>
        /// 获取角色
        /// </summary>
        /// <param name="OUID"></param>
        /// <returns></returns>
        /// 
        List<BPMSysOURoles> RoleBind(int OUID);
        /// <summary>
        /// 员工录用单个信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employe GetEmploye(int id);
        /// <summary>
        /// 员工亲属单个信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Relati GetRelati(int id);
        
    }
}
