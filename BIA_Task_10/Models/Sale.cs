namespace BIA_Task_10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sale")]
    public partial class Sale
    {
        public int SaleID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "date")]
        public DateTime AuctionDate { get; set; }

        public decimal StartPrice { get; set; }

        public decimal LastPrice { get; set; }

        public bool SaleStatus { get; set; }

        [StringLength(150)]
        public string ClientFIO { get; set; }

        public virtual Item Item { get; set; }
    }
}
