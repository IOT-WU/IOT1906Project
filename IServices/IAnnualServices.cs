using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainDTO.EFModels;
using System.Threading.Tasks;

namespace IServices
{
    public interface IAnnualServices
    {
        int Annual_add(Annual_information _information);
    }
}
