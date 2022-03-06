using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.EFModels
{
    public class Sacceptance
    {
        /// <summary>
        /// 固定资产验收基础表
        /// </summary>
        [Key]
        public int Sacceptance_Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Sacceptance_Apply { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Sacceptance_Depart { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime Sacceptance_Data { get; set; }
        /// <summary>
        /// 资产编号
        /// </summary>
        public int Sacceptance_Card { get; set; }
        /// <summary>
        /// 资产类别
        /// </summary>
        public int Sacceptance_Type { get; set; }
        /// <summary>
        /// 存放地点
        /// </summary>
        public string Sacceptance_Addr { get; set; }
        /// <summary>
        /// 请购单号
        /// </summary>
        public string Sacceptance_QCard { get; set; }
        /// <summary>
        /// 所属项目
        /// </summary>
        public string Sacceptance_Project { get; set; }
        /// <summary>
        /// 使用人
        /// </summary>
        public int Sacceptance_Use { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public int Sacceptance_BuDepat { get; set; }
    }
}
