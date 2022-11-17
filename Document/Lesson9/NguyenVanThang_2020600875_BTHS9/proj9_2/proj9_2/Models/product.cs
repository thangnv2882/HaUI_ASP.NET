namespace proj9_2.Models
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
        [Required(ErrorMessage = "Mã sản phẩm không được để trống")]
        [DisplayName("Mã sản phẩm")]
        public int proid { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(45)]
        [DisplayName("Tên sản phẩm")]
        public string proname { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        [DisplayName("Giá")]
        public decimal price { get; set; }

        [Required(ErrorMessage = "Cổ phần không được để trống")]
        [DisplayName("Cổ phần")]
        public decimal stock { get; set; }

        [StringLength(100)]
        [DisplayName("Ảnh")]
        public string image { get; set; }

        [Column(TypeName = "ntext")]
        [DisplayName("Mô tả")]
        public string description { get; set; }

        public int catid { get; set; }

        public virtual category category { get; set; }
    }
}
