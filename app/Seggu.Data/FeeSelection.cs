//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seggu.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeeSelection
    {
        public FeeSelection()
        {
            this.Fees = new HashSet<Fee>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Total { get; set; }
        public System.Guid LiquidationId { get; set; }
        public string Notes { get; set; }
    
        public virtual Liquidation Liquidation { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
    }
}