namespace BuiNgocTien_CNTT3K61_BT1_201207598.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tChatLieu")]
    public partial class tChatLieu
    {
        [Key]
        [StringLength(25)]
        public string MaChatLieu { get; set; }

        [StringLength(150)]
        public string ChatLieu { get; set; }
    }
}
