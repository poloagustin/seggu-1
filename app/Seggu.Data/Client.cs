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
    
    public partial class Client
    {
        public Client()
        {
            this.Policy = new HashSet<Policy>();
            this.ClientCreditCards = new HashSet<ClientCreditCard>();
            this.Endorse = new HashSet<Endorse>();
            this.Addresses = new HashSet<Address>();
        }
    
        public System.Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public string Mail { get; set; }
        public string Document { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Cuit { get; set; }
        public string IngresosBrutos { get; set; }
        public string CollectionTimeRange { get; set; }
        public string BankingCode { get; set; }
        public string Notes { get; set; }
        public bool IsSmoker { get; set; }
        public Sex Sex { get; set; }
        public IVA IVA { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public IdType DocumentType { get; set; }
        public string Occupation { get; set; }
    
        public virtual ICollection<Policy> Policy { get; set; }
        public virtual ICollection<ClientCreditCard> ClientCreditCards { get; set; }
        public virtual ICollection<Endorse> Endorse { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}