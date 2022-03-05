using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDTO.EFModels;
using IRepository;
using IServices;
using MyDB;

namespace Services
{
    public class EmpServices : IEmpServices
    {
        private readonly IRepositoryDB<BPMSysOUs> repository;
        private readonly IRepositoryDB<Employe> repositorydb;
        private readonly IRepositoryDB<Relati> relatidb;
        private readonly  MyDBContext myDBContext;
        public EmpServices(IRepositoryDB<BPMSysOUs> repository,MyDBContext myDBContext,IRepositoryDB<Employe> repositorydb,IRepositoryDB<Relati> relatidb)
        {
            this.repository = repository;
            this.myDBContext = myDBContext;
            this.repositorydb = repositorydb;
            this.relatidb = relatidb;
        }
        /// <summary>
        /// 获取部门
        /// </summary>
        /// <returns></returns>
        public List<BPMSysOUs> Bind()
        {
            var list = repository.QueryList(x=>x.OUID.Equals(x.OUID));
            return list;
        }
        /// <summary>
        /// 获取员工录用单个信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employe GetEmploye(int id)
        {
            return repositorydb.GetModel(x => x.Employed_Id.Equals(id));
        }
        /// <summary>
        /// 获取员工亲属单个信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Relati GetRelati(int id)
        {
            return relatidb.GetModel(x => x.Relative_Id.Equals(id));
        }

        /// <summary>
        /// 获取角色
        /// </summary>
        /// <param name="OUID"></param>
        /// <returns></returns>
        public List<BPMSysOURoles> RoleBind(int OUID)
        {
            var list = myDBContext.BPMSysOURoles.ToList();
            if (OUID != 0)
            {
                list = list.Where(x => x.OUID == OUID).ToList();
            }
            return list;
         
        }
    }
}
