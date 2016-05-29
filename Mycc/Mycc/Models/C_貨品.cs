namespace Mycc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_貨品")]
    public partial class C_貨品
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_貨品()
        {
            INM = new HashSet<INM>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int 貨品Id { get; set; }

        [Key]
        [StringLength(20)]
        public string 貨品名稱 { get; set; }

        [Column(TypeName = "money")]
        public decimal? 價格 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INM> INM { get; set; }
    }
}
