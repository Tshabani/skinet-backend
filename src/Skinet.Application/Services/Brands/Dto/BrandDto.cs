using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Skinet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skinet.Services.Brands.Dto
{
    [AutoMapFrom(typeof(Brand))]
    public class BrandDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
