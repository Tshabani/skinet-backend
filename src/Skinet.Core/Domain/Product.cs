using Abp.Domain.Entities.Auditing;
using System;

namespace Skinet.Domain
{
    public class Product : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual double Price { get; set; }
        public virtual string PictureUrl { get; set; }
        public virtual ProductType ProductType { get; set; } 
        public virtual Brand ProductBrand { get; set; }
    }
}
