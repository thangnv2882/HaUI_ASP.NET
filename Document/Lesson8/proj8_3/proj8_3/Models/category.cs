namespace proj8_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("category")]
    public partial class category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public category()
        {
            products = new HashSet<product>();
        }

        [Key]
        [Required(ErrorMessage ="M� danh m?c kh�ng ???c ?? tr?ng")]
        [DisplayName("M� danh m?c")]
        public int catid { get; set; }

        [Required(ErrorMessage = "T�n danh m?c kh�ng ???c ?? tr?ng")]
        [DisplayName("T�n danh m?c")]
        [StringLength(50)]
        public string catname { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product> products { get; set; }
    }
}
