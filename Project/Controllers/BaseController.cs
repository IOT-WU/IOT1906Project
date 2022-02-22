using BPMAPI.OtherApi;
using bpmdemoapi.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        private IConfiguration configuration;
        public BaseController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        /// <summary>
        /// 获取table
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static DataSet GetDataSet(Object data)
        {
            Type type = data.GetType();
            DataSet formDataSet = new DataSet("FormData");

            DataTable table = new DataTable(type.Name);
            string IsNotField = "Action,BPMUser,BPMUserPass,FullName,ProcessName";
            foreach (var property in type.GetProperties())
            {
                if (!IsNotField.Contains(property.Name))
                    table.Columns.Add(new DataColumn(property.Name, property.PropertyType));
            }
            DataRow add_row = table.NewRow();
            foreach (var property in type.GetProperties())
            {
                if (!IsNotField.Contains(property.Name))
                    add_row[property.Name] = property.GetValue(data);
            }
            table.Rows.Add(add_row);
            formDataSet.Tables.Add(table);
            return formDataSet;
        }
        public Task<int> StartProccess<T>(T leaveNew) where T : BaseModels, new()
        {
            string formDataSet = ConvertXML.ConvertDataSetToXML(GetDataSet(leaveNew));
            BPMModels models = new BPMModels(configuration)
            {
                Action = leaveNew.Action,

                BPMUser = leaveNew.BPMUser,
                BPMUserPass = leaveNew.BPMUserPass,
                FormDataSet = formDataSet,
                FullName = leaveNew.FullName,
                ProcessName = leaveNew.ProcessName
            };
            return MyClientApi.OptClientApi(models.BpmServerUrl, models);
        }
    }
}
