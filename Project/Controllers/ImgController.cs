using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Data;
using DomainDTO.InPutModels;
using IServices;
using Project.OtherApi;

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
        [HttpPost, Route("api/DownloadExcel")]
        public IActionResult DownloadExcel(List<OutPutOwnerProcess> ls)
        {
            //var ls = userServices.GetRunningProcess().Result;
            string[] vs = new string[] { "Key", "流水号", "流程名称", "持有人", "发起时间", "审批节点状态", "审批状态", "TaskID", "StepID", "审批人" };
            //引用静态类
            var excel = ConvertExcel.OutputExcel(ls, vs);
            return File(excel, "application/ms-excel", "导出数据.xlsx");
        }
        /// <summary>
        /// 所有流程导出Excel
        /// </summary>
        [HttpGet, Route("api/DownloadAllExcel")]
        public IActionResult DownloadAllExcel()
        {
            var ls = userServices.GetAllProcess();
            string[] vs = new string[] { "Key", "流水号", "流程名称", "持有人", "发起时间", "审批节点状态", "审批状态", "TaskID", "StepID", "审批人" };
            //引用静态类
            var excel = ConvertExcel.OutputExcel(ls, vs);
            return File(excel, "application/ms-excel", "导出数据.xlsx");
        }

    }
}
