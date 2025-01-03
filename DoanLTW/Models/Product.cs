//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoanLTW.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int ProId { get; set; }
        public string ProName { get; set; }
        public string ProImage { get; set; }
        public string SetName { get; set; }
        public string ProNumber { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> MarketPrice { get; set; }
        public string CardType { get; set; }
        public string AttackPower1 { get; set; }
        public string AttackPower2 { get; set; }
        public Nullable<int> CatId { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
