namespace BuiNgocTien_CNTT3K61_BT1_201207598.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tLoaiDT")]
    public partial class tLoaiDT
    {
        [Key]
        [StringLength(25)]
        public string MaDT { get; set; }

        [StringLength(100)]
        public string TenLoai { get; set; }
    }
}
