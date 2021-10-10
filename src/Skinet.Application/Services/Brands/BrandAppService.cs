using Abp.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skinet.Services.Brands
{
    [AbpAuthorize]
    public class BrandAppService : IBrandAppService
    {
        public BrandAppService()
        {

        }
    }
}
