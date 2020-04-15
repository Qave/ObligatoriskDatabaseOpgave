namespace OblDatabaseOpgave
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingsView")]
    public partial class BookingsView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Booking_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Hotel_No { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Guest_No { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime Date_From { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime Date_To { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Booking_id}, {Hotel_No}, {Guest_No}, {Date_From}, {Date_To}, {Name}, {Address}";
        }
    }
}
