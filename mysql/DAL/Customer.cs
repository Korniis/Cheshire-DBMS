//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace mysql.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int id { get; set; }
        public Nullable<int> MemberId { get; set; }
        public string Name { get; set; }
        public string Telphone { get; set; }
        public string Nation { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string Tag { get; set; }
    }
}
