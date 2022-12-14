//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Electronics_Shop.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_ShippingDetails
    {
        public int ShippingDetailId { get; set; }
        public Nullable<int> MemberId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
        public string PaymentType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public Nullable<int> InvoiceId { get; set; }
        public string State { get; set; }
    
        public virtual Tbl_Members Tbl_Members { get; set; }
        public virtual SiteUser SiteUser { get; set; }
        public virtual tbl_invoice tbl_invoice { get; set; }
        public virtual tbl_order tbl_order { get; set; }
    }
}
