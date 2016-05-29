namespace Mycc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 貨品表
    {
        [StringLength(255)]
        public string ID { get; set; }

        [StringLength(255)]
        public string 貨品名稱 { get; set; }

        [StringLength(255)]
        public string 存貨 { get; set; }
    }
}
