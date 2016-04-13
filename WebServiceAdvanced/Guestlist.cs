namespace WebServiceAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Guestlist")]
    public partial class Guestlist
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string HotelName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Room_Number { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string GuestName { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime Booking_DateFrom { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime Booking_DateTo { get; set; }

        public override string ToString()
        {
            return ("Guest at: " + HotelName + ",\t" + Room_Number + ",\t" + GuestName + " ,\t" + Booking_DateFrom + " ,\t" + Booking_DateTo);
        }
    }
}
