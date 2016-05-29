namespace Mycc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INM")]
    public partial class INM
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? 日期 { get; set; }

        [StringLength(8)]
        public string 代理 { get; set; }

        [StringLength(50)]
        public string 支付方式 { get; set; }

        [StringLength(20)]
        public string 產品 { get; set; }

        [StringLength(50)]
        public string 數量 { get; set; }

        [Column(TypeName = "money")]
        public decimal? 價格 { get; set; }

        public bool? 已發貨 { get; set; }

        public virtual C_代理 C_代理 { get; set; }

        public virtual C_貨品 C_貨品 { get; set; }
    }
}
