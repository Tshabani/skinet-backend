using Abp.Domain.Entities.Auditing;
using System;

namespace Skinet.Domain
{
    public class Brand : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
    }
}
