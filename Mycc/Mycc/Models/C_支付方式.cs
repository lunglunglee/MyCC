namespace Mycc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_支付方式")]
    public partial class C_支付方式
    {
        [Key]
        [StringLength(50)]
        public string 支付方式id { get; set; }

        [StringLength(50)]
        public string 支付宝 { get; set; }

        [StringLength(50)]
        public string 微信 { get; set; }

        [StringLength(50)]
        public string NULl { get; set; }
    }
}
