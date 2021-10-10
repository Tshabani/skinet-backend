using Abp.Domain.Entities.Auditing;
using System;

namespace Skinet.Domain
{
    public class ProductType : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
    }
}
