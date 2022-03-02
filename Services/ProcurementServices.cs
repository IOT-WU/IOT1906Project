using DomainDTO.EFModels;
using DomainDTO.OutPutModels;
using IRepository;
using IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProcurementServices : IProcurementServices
    {
        private readonly IRepositoryDB<ProcurementDetails> repository;
        public ProcurementServices(IRepositoryDB<ProcurementDetails> repository)
        {
            this.repository = repository;
        }

        List<ProcurementOutput> IProcurementServices.GetProcurement(string Name)
        {
            var list = (from s in repository.QueryList(x => x.Goods_Name.Contains(Name))
                        select new ProcurementOutput
                        {
                            Goods_Id = s.Goods_Id,
                            Goods_Name = s.Goods_Name,
                            Goods_Specifications = s.Goods_Specifications,
                            Goods_Num = s.Goods_Num,
                            Goods_Unit = s.Goods_Unit,
                            Goods_Price = s.Goods_Price,
                            Goods_Money = s.Goods_Money,
                            Goods_Note = s.Goods_Note
                        }).ToList();
            return list;
        }
    }
}
