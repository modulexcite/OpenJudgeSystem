//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OJS.Tools.OldDatabaseMigration
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public int Id { get; set; }
        public int From { get; set; }
        public Nullable<int> Contest { get; set; }
        public string Message { get; set; }
        public System.DateTime Time { get; set; }
        public bool Active { get; set; }
    
        public virtual Contest Contest1 { get; set; }
        public virtual User User { get; set; }
    }
}
