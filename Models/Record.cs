//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record
    {
        public int Id { get; set; }
        public int CargoId { get; set; }
        public string CargoName { get; set; }
        public double Number { get; set; }
        public string Tag { get; set; }
        public System.DateTime InsertDate { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
    }
}
