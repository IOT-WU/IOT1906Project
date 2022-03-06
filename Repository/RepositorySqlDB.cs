
using IRepository;
using MyDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    /// <summary>
    /// 连接SqlServer
    /// </summary>

    public class RepositorySqlDB<T> : IRepositoryDB<T> where T : class, new()
    {
        //注入上下文DB
        private readonly MyDBContext db;
        public RepositorySqlDB(MyDBContext db)
        {
            this.db = db;
        }
        /// <summary>
        /// 添加数据对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int ExecuteAdd(T model)
        {
            db.Set<T>().Add(model);
            return db.SaveChanges();
        }

        /// <summary>
        /// 删除数据对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int ExecuteDel(int id)
        {
            var obj = db.Set<T>().Find(id);
            db.Set<T>().Remove(obj);
            return db.SaveChanges();
        }

        /// <summary>
        /// 修改数据对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int ExecuteUpd(T model)
        {
            db.Set<T>().Update(model);
            return db.SaveChanges();
        }

        

        /// <summary>
        /// 获取单个数据对象
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public T GetModel(Expression<Func<T, bool>> exception)
        {
            var model = db.Set<T>().AsQueryable().FirstOrDefault(exception);
            return model;
        }

        /// <summary>
        /// 获取数据集合
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public List<T> QueryList(Expression<Func<T, bool>> exception)
        {
            var list = db.Set<T>().AsQueryable().Where(exception).ToList();
            return list;
        }
      
    }
}
