//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaneOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonelIzin
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Personel Personel { get; set; }
    }
}
