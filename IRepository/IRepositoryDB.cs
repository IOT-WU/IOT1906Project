using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace IRepository
{
    public interface IRepositoryDB<T> where T : class, new()
    {
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="model">添加的数据</param>
        /// <returns></returns>
        int ExecuteAdd(T model);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id">需要删除的数据的Id</param>
        /// <returns></returns>
        int ExecuteDel(int id);
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="model">修改的数据</param>
        /// <returns></returns>
        int ExecuteUpd(T model);
        /// <summary>
        /// 显示集合数据
        /// </summary>
        /// <param name="exception">lambda表达式</param>
        /// <returns></returns>
        List<T> QueryList(Expression<Func<T, bool>> exception);
        /// <summary>
        /// 获取单个对象
        /// </summary>
        /// <param name="exception">lambda表达式</param>
        /// <returns></returns>
        T GetModel(Expression<Func<T, bool>> exception);
    }
}
