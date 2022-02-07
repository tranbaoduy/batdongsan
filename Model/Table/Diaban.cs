using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace batdongsan.Model.Table
{
    [Table("Diaban")]
    public class Diaban
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("MaDiaBan")]
        [StringLength(50)]
        public string MaDiaBan { get; set; }
        [Column("TenDiaBan")]
        [StringLength(200)]
        public string TenDiaBan { get; set; }
        [Column("MaCha")]
        [StringLength(50)]
        public string MaCha { get; set; }
    }

}