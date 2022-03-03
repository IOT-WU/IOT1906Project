using DomainDTO.EFModels;
using IRepository;
using IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class ApiServer :IProductService
    {
        readonly IRepositoryDB<Maintain> _product;
        readonly IRepositoryDB<MInsurance> _minsurance;
        readonly IRepositoryDB<Mrepair> _mrpair;
        readonly IRepositoryDB<MViolation> _mviolation;
        readonly IRepositoryDB<Resources> _resources;
        readonly IRepositoryDB<Employed> _employed;
        public ApiServer(IRepositoryDB<Maintain> product, IRepositoryDB<MInsurance> minsurance, IRepositoryDB<Mrepair> mrpair, IRepositoryDB<MViolation> mviolation, IRepositoryDB<Resources> resources, IRepositoryDB<Employed> employed)
        {
            _product = product;
            _minsurance = minsurance;
            _mrpair = mrpair;
            _mviolation = mviolation;
            _resources = resources;
            _employed = employed;
        }

        public int Adder1(Maintain maintain)
        {
            return _product.ExecuteAdd(maintain);
        }

        public int Adder2(MInsurance mInsurancea)
        {
            return _minsurance.ExecuteAdd(mInsurancea);
        }

        public int Adder3(Mrepair mrepair)
        {
            return _mrpair.ExecuteAdd(mrepair);
        }

        public int Adder4(MViolation mViolation)
        {
            return _mviolation.ExecuteAdd(mViolation);
        }

        public Resources find(int id)
        {
            return _resources.GetModel(a => a.staff_Id.Equals(id));
        }
        public Employed staff(int id)
        {
            return _employed.GetModel(a => a.Employed_Id.Equals(id));
        }
    }
}
