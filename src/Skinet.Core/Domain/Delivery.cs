using Abp.Domain.Entities.Auditing;
using System;

namespace Skinet.Domain
{
    public class Delivery : FullAuditedEntity<Guid>
    {
        public virtual string ShortName { get; set; }
        public virtual string Description { get; set; }
        public virtual string DeliveryTime { get; set; }
        public virtual int Price { get; set; }
    }
}
