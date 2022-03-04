using DomainDTO.OutPutModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    public interface IProcurementServices
    {
        List<ProcurementOutput> GetProcurement(string Name);
    }
}
