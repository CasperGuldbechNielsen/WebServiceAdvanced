namespace WebServiceAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SingleRoom
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Hotel_Number { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Hotel_Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Room_Number { get; set; }

        [Key]
        [Column(Order = 3)]
        public double Room_Price { get; set; }

        [StringLength(1)]
        public string Room_Type { get; set; }
    }
}
