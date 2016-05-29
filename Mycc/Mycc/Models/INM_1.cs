namespace Mycc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INM_1
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
    }
}
