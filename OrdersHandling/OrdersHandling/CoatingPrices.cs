//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrdersHandling
{
    using System;
    using System.Collections.Generic;
    
    public partial class CoatingPrices
    {
        public int ID { get; set; }
        public int PartnerCoatingGrpID { get; set; }
        public int CoatingGroupID { get; set; }
        public Nullable<double> Price { get; set; }
        public int MuID { get; set; }
    
        public virtual CoatingPrices CoatingPrices1 { get; set; }
        public virtual CoatingPrices CoatingPrices2 { get; set; }
        public virtual MU MU { get; set; }
        public virtual PartnerCoatingGroup PartnerCoatingGroup { get; set; }
    }
}