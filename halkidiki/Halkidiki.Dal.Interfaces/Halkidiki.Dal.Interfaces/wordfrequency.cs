//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Halkidiki.Dal.Interfaces
{
    using System;
    using System.Collections.Generic;
    
    public partial class wordfrequency
    {
        public int id { get; set; }
        public int idword { get; set; }
        public int idappuser { get; set; }
        public Nullable<int> frequency { get; set; }
        public int idlanguage { get; set; }
        public Nullable<int> ismemorized { get; set; }
    
        public virtual appuser appuser { get; set; }
        public virtual word word { get; set; }
        public virtual language language { get; set; }
    }
}
