namespace Mycc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_代理")]
    public partial class C_代理
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_代理()
        {
            INM = new HashSet<INM>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int 代理Id { get; set; }

        [Key]
        [StringLength(8)]
        public string 代理名稱 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INM> INM { get; set; }
    }
}
