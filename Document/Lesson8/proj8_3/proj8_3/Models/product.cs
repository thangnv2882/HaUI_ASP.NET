namespace proj8_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [Key]
        [Required(ErrorMessage ="Mã s?n ph?m không ???c ?? tr?ng")]
        [DisplayName("Mã s?n ph?m")]
        public int proid { get; set; }

        [Required(ErrorMessage = "Tên s?n ph?m không ???c ?? tr?ng")]
        [DisplayName("Tên s?n ph?m")]
        [StringLength(45)]
        public string proname { get; set; }

        [DisplayName("Giá s?n ph?m")]
        public decimal price { get; set; }

        [DisplayName("C? ph?n")]
        public decimal stock { get; set; }

        [DisplayName("?nh s?n ph?m")]
        [StringLength(100)]
        public string image { get; set; }

        [DisplayName("Mô t?")]
        [Column(TypeName = "ntext")]
        public string description { get; set; }

        public int catid { get; set; }

        public virtual category category { get; set; }
    }
}
