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
    
    public partial class VehicleType
    {
        public VehicleType()
        {
            this.Uses = new HashSet<Use>();
            this.Bodyworks = new HashSet<Bodywork>();
            this.VehicleModels = new HashSet<VehicleModel>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Use> Uses { get; set; }
        public virtual ICollection<Bodywork> Bodyworks { get; set; }
        public virtual ICollection<VehicleModel> VehicleModels { get; set; }
    }
}