namespace Mycc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data_Area
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AreaId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string AreaCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string AreaName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string CityCode { get; set; }
    }
}
