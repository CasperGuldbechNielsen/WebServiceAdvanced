namespace WebServiceAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HotelRoom")]
    public partial class HotelRoom
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string HotelName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Room_Number { get; set; }

        [StringLength(1)]
        public string Room_Type { get; set; }

        [Key]
        [Column(Order = 2)]
        public double Room_Price { get; set; }
    }
}
