namespace Mycc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data_City
    {
        public int CityId { get; set; }

        [Key]
        [StringLength(6)]
        public string CityCode { get; set; }

        [Required]
        [StringLength(50)]
        public string CityName { get; set; }

        [Required]
        [StringLength(6)]
        public string ProvinceCode { get; set; }

        public virtual Data_Province Data_Province { get; set; }
    }
}
