namespace Assignment_One.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trasnaction-Info")]
    public partial class Trasnaction_Info
    {
        [Key]
        [StringLength(10)]
        public string productId { get; set; }

        [Column("game-title")]
        [Required]
        [StringLength(50)]
        public string game_title { get; set; }

        [Column("customer-name")]
        [Required]
        [StringLength(50)]
        public string customer_name { get; set; }

        [Column("customer-number")]
        [Required]
        [StringLength(10)]
        public string customer_number { get; set; }

        [Column("date-purchased")]
        [DataType(DataType.Date)]
        public DateTime date_purchased { get; set; }

        [Column("customer-payment")]
        [Required]
        [StringLength(10)]
        public string customer_payment { get; set; }

        [Column("game-inventory")]
        [StringLength(10)]
        public string game_inventory { get; set; }

        [Column("payment-confirmed")]
        [Required]
        [StringLength(1)]
        public string payment_confirmed { get; set; }
    }
}
