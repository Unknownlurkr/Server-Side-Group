namespace Assignment_One.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Game-Inventory")]
    public partial class Game_Inventory
    {
        [Key]
        [StringLength(10)]
        public string productId { get; set; }

        [Column("game-title")]
        [Required]
        [StringLength(50)]
        public string game_title { get; set; }

        [Column("game-genre")]
        [Required]
        [StringLength(50)]
        public string game_genre { get; set; }

        [Column("age-restiction-rating")]
        [StringLength(2)]
        public string age_restiction_rating { get; set; }

        [Column("date-release", TypeName = "date")]
        public DateTime date_release { get; set; }

        [Column("game-owners")]
        [Required]
        [StringLength(50)]
        public string game_owners { get; set; }

        [Column("game-ratings")]
        [StringLength(10)]
        public string game_ratings { get; set; }

        [Column("in-Stock")]
        [StringLength(1)]
        public string in_Stock { get; set; }

        [Column("game-price", TypeName = "numeric")]
        public decimal game_price { get; set; }

        [Column("modable-game")]
        [Required]
        [StringLength(1)]
        public string modable_game { get; set; }

        [Column("type-of-game")]
        [StringLength(15)]
        public string type_of_game { get; set; }
    }
}
