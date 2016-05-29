namespace MyApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OutM")]
    public partial class OutM
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? 日期 { get; set; }

        [StringLength(50)]
        public string 貨品 { get; set; }

        [StringLength(50)]
        public string 紙箱 { get; set; }

        [StringLength(50)]
        public string 板費 { get; set; }

        [StringLength(50)]
        public string 快遞 { get; set; }

        [StringLength(50)]
        public string 輔料 { get; set; }

        [StringLength(50)]
        public string 其他 { get; set; }
    }
}
