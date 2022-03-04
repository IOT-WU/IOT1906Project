using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Project.Controllers
{
    [ApiController]
    public class ImgController : ControllerBase
    {
        #region 文件上传
        //文件上传
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
        public string UpLoadFiles(IFormFile file)
        {
            //存放虚拟路径
            var fileDir = "wwwrokot\\Imgs";
            //文件名称
            string fileName = file.FileName;
            //文件大小
            var fileSize = file.Length / 1024;
            //获取后缀名
            int index = fileName.IndexOf('.') + 1;
            int length = fileName.Length;
            string fileSuffix = fileName.Substring(index, length - index);  //类型
            var CreateTime = DateTime.Now;  //创建时间

            //上传的文件的路径
            string filePath = fileDir + $@"\{fileName}";
            using (FileStream fs = System.IO.File.Create(filePath))
            {
                file.CopyTo(fs);
                fs.Flush();
            }
            //换成添加到数据库就行
            return fileName;
        }
        #endregion
    }
}
