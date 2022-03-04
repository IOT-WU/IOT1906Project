using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text;
using DevExpress.Utils.CommonDialogs.Internal;
using NPOI.SS.UserModel;
using DomainDTO.InPutModels;
using NPOI.XSSF.UserModel;
using System.Reflection;
using IServices;

namespace Project.Controllers
{
    [ApiController]
    public class ImgController : ControllerBase
    {
        private readonly IUserServices userServices;
        public ImgController(IUserServices userServices)
        {
            this.userServices = userServices;
        }

        #region 图片上传
        //图片上传
        [HttpPost("Img/Upload")]
        public string uploadProject(IFormFile file)
        {
            //判断是否有文件
            if (file != null)
            {
                var fileDir = "wwwroot\\Imgs";
                //判断项目是否包含文件夹
                if (!Directory.Exists(fileDir))
                {
                    //不包含文件夹就去创建一个文件夹
                    Directory.CreateDirectory(fileDir);
                }
                //文件名称
                string fileName = file.FileName;
                int index = fileName.IndexOf('.');
                int length = fileName.Length;
                //后缀名
                string houzui = fileName.Substring(index, length - index);
                //拼接文件名
                fileName = DateTime.Now.ToString("yyyyMMddhhmmss") + houzui;

                //上传的文件的路径
                string filePath = fileDir + $@"\{fileName}";
                using (FileStream fs = System.IO.File.Create(filePath))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
                return fileName;
            }
            else
            {
                //没有文件返回 no
                return "no";
            }
        }
        #endregion

        #region 文件上传
        //文件上传
        [HttpPost("Files/Upload")]
        public string FilesUpload(IFormFile file)
        {
            //判断是否有文件
            if (file != null)
            {
                var fileDir = "wwwroot\\Imgs";
                //判断项目是否包含文件夹
                if (!Directory.Exists(fileDir))
                {
                    //不包含文件夹就去创建一个文件夹
                    Directory.CreateDirectory(fileDir);
                }
                //文件名称
                string fileName = file.FileName;
                int index = fileName.IndexOf('.');
                int length = fileName.Length;
                //后缀名
                string houzui = fileName.Substring(index, length - index);
                //拼接文件名
                fileName = DateTime.Now.ToString("yyyyMMddhhmmss") + houzui;

                //上传的文件的路径
                string filePath = fileDir + $@"\{fileName}";
                using (FileStream fs = System.IO.File.Create(filePath))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
                return fileName;
            }
            else
            {
                //没有文件返回 no
                return "no";
            }
        }
        #endregion

        /// <summary>
        /// 流程导出Excel
        /// </summary>
        [HttpPost, Route("api/OutPutExcel")]
        public IActionResult OutPutExcel(List<OutPutOwnerProcess> ls)
        {
            //var ls = userServices.GetRunningProcess().Result;
            string[] vs = new string[] { "Key", "流水号", "流程名称", "持有人", "发起时间", "审批节点状态", "审批状态", "TaskID", "StepID", "审批人" };
            var excel = OutputExcel(ls, vs);
            return File(excel, "application/ms-excel", "导出数据.xlsx");
        }

        #region 流程导出Excel
        //流程导出Excel
        public static byte[] OutputExcel(List<OutPutOwnerProcess> entitys, string[] title)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("sheet");
            IRow Title = null;
            IRow rows = null;
            Type entityType = entitys[0].GetType();
            PropertyInfo[] entityProperties = entityType.GetProperties();

            for (int i = 0; i <= entitys.Count; i++)
            {
                if (i == 0)
                {
                    Title = sheet.CreateRow(0);
                    for (int k = 1; k < title.Length + 1; k++)
                    {
                        Title.CreateCell(0).SetCellValue("序号");
                        Title.CreateCell(k).SetCellValue(title[k - 1]);
                    }

                    continue;
                }
                else
                {
                    rows = sheet.CreateRow(i);
                    object entity = entitys[i - 1];
                    for (int j = 1; j <= entityProperties.Length; j++)
                    {
                        object[] entityValues = new object[entityProperties.Length];
                        entityValues[j - 1] = entityProperties[j - 1].GetValue(entity);
                        rows.CreateCell(0).SetCellValue(i);
                        rows.CreateCell(j).SetCellValue(entityValues[j - 1].ToString());
                    }
                }
            }

            byte[] buffer = new byte[1024 * 2];
            using (MemoryStream ms = new MemoryStream())
            {
                workbook.Write(ms);
                buffer = ms.ToArray();
                ms.Close();
            }

            return buffer;
        }
        #endregion
    }
}
