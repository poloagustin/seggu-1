namespace Seggu.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class CoveragesPack : KeyValueEntity
    {
        public CoveragesPack()
        {
            this.Coverages = new HashSet<Coverage>();
        }
    
        public long RiskId { get; set; }
    
        public virtual Risk Risk { get; set; }
        public virtual ICollection<Coverage> Coverages { get; set; }
    }
}
