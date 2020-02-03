namespace Assignment_One.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer-Info")]
    public partial class Customer_Info
    {
        [Key]
        [StringLength(10)]
        public string productId { get; set; }

        [Column("game-title")]
        [Required]
        [StringLength(50)]
        public string game_title { get; set; }

        [Column("game-price")]
        public decimal game_price { get; set; }

        [Column("customer-name")]
        [Required]
        [StringLength(50)]
        public string customer_name { get; set; }

        [Column("date-purchased", TypeName = "date")]
        public DateTime date_purchased { get; set; }

        [Column("customer-email")]
        [StringLength(50)]
        public string customer_email { get; set; }

        [Column("customer-phone")]
        [Required]
        [StringLength(10)]
        public string customer_phone { get; set; }

        [Column("purchase-card-num")]
        [Required]
        [StringLength(15)]
        public string purchase_card_num { get; set; }

        [Column("purchase-ccv")]
        [Required]
        [StringLength(3)]
        public string purchase_ccv { get; set; }

        [Column("shipping-address")]
        [Required]
        [StringLength(50)]
        public string shipping_address { get; set; }

        [Column("billing-address")]
        [StringLength(50)]
        public string billing_address { get; set; }
    }
}
