namespace proj9_2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account")]
    public partial class account
    {
        [Key]
        [Required(ErrorMessage = "Mã người dùng không được để trống")]
        [DisplayName("Mã người dùng")]
        public int id { get; set; }

        [Required(ErrorMessage = "Tên người dùng không được để trống")]
        [StringLength(50)]
        [DisplayName("Tên người dùng")]
        public string username { get; set; }

        [Required(ErrorMessage = "Tên đầy đủ không được để trống")]
        [StringLength(30)]
        [DisplayName("Tên đầy đủ")]
        public string fullname { get; set; }

        [Required(ErrorMessage = "Điện thoại không được để trống")]
        [StringLength(20)]
        [DisplayName("Điện thoại")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(30)]
        [DisplayName("Mật khẩu")]
        public string password { get; set; }

        [StringLength(50)]
        [DisplayName("Email")]
        public string email { get; set; }
    }
}
