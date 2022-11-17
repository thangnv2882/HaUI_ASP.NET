namespace proj9_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Mã sản phẩm không được để trống")]
        [DisplayName("Mã sản phẩm")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(50)]
        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }

        [Column(TypeName = "text")]
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Giá nhập không được để trống")]
        [Column(TypeName = "numeric")]
        [DisplayName("Giá nhập")]
        public decimal PurchasePrice { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        [Column(TypeName = "numeric")]
        [DisplayName("Giá")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trống")]
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        [StringLength(20)]
        [DisplayName("Năm sản xuất")]
        public string Vintage { get; set; }

        [Required]
        [StringLength(10)]
        public string CatalogyID { get; set; }

        [Column(TypeName = "text")]
        [DisplayName("Ảnh")]
        public string Image { get; set; }

        [Required(ErrorMessage ="Vùng không được để trống")]
        [StringLength(100)]
        [DisplayName("Vùng")]
        public string Region { get; set; }

        public virtual Catalogy Catalogy { get; set; }
    }
}
