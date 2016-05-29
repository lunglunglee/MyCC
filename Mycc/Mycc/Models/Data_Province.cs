namespace Mycc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data_Province
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Data_Province()
        {
            Data_City = new HashSet<Data_City>();
        }

        public int ProvinceId { get; set; }

        [Key]
        [StringLength(6)]
        public string ProvinceCode { get; set; }

        [Required]
        [StringLength(50)]
        public string ProvinceName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Data_City> Data_City { get; set; }
    }
}
