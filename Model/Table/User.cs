using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace batdongsan.Model.Table
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column("UserId")]
        public int UserId { get; set; }

        [Column("UserName")]
        [StringLength(200)]
        public string UserName { get; set; }    

        [Column("PassWord")]
        [StringLength(200)]
        public string PassWord { get; set; }

        [Column("ChucVu")]
        public int ChucVu { get; set; }
        

    }
}