namespace Assignment_One.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=games")
        {
        }

        public virtual DbSet<Customer_Info> Customer_Info { get; set; }
        public virtual DbSet<Game_Inventory> Game_Inventory { get; set; }
        public virtual DbSet<Trasnaction_Info> Trasnaction_Info { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer_Info>()
                .Property(e => e.productId)
                .IsFixedLength();

            modelBuilder.Entity<Customer_Info>()
                .Property(e => e.game_price)
                .HasPrecision(2, 2);

            modelBuilder.Entity<Customer_Info>()
                .Property(e => e.customer_email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Info>()
                .Property(e => e.customer_phone)
                .IsFixedLength();

            modelBuilder.Entity<Customer_Info>()
                .Property(e => e.purchase_card_num)
                .IsFixedLength();

            modelBuilder.Entity<Customer_Info>()
                .Property(e => e.purchase_ccv)
                .IsFixedLength();

            modelBuilder.Entity<Customer_Info>()
                .Property(e => e.billing_address)
                .IsUnicode(false);

            modelBuilder.Entity<Game_Inventory>()
                .Property(e => e.productId)
                .IsFixedLength();

            modelBuilder.Entity<Game_Inventory>()
                .Property(e => e.game_title)
                .IsUnicode(false);

            modelBuilder.Entity<Game_Inventory>()
                .Property(e => e.game_genre)
                .IsUnicode(false);

            modelBuilder.Entity<Game_Inventory>()
                .Property(e => e.age_restiction_rating)
                .IsFixedLength();

            modelBuilder.Entity<Game_Inventory>()
                .Property(e => e.game_ratings)
                .IsFixedLength();

            modelBuilder.Entity<Game_Inventory>()
                .Property(e => e.in_Stock)
                .IsFixedLength();

            modelBuilder.Entity<Game_Inventory>()
                .Property(e => e.game_price)
                .HasPrecision(2, 2);

            modelBuilder.Entity<Game_Inventory>()
                .Property(e => e.modable_game)
                .IsFixedLength();

            modelBuilder.Entity<Game_Inventory>()
                .Property(e => e.type_of_game)
                .IsUnicode(false);

            modelBuilder.Entity<Trasnaction_Info>()
                .Property(e => e.productId)
                .IsFixedLength();

            modelBuilder.Entity<Trasnaction_Info>()
                .Property(e => e.customer_number)
                .IsFixedLength();

            modelBuilder.Entity<Trasnaction_Info>()
                .Property(e => e.customer_payment)
                .IsFixedLength();

            modelBuilder.Entity<Trasnaction_Info>()
                .Property(e => e.game_inventory)
                .IsFixedLength();

            modelBuilder.Entity<Trasnaction_Info>()
                .Property(e => e.payment_confirmed)
                .IsFixedLength();
        }
    }
}
