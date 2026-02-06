namespace practica_5.FolderforModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Motorbike
    {
        public double ID { get; set; }

        [StringLength(255)]
        public string Model { get; set; }

        [StringLength(255)]
        public string Brand { get; set; }

        public double? Price { get; set; }

        public double? Horsepower { get; set; }

        public double? Mileage { get; set; }

        [StringLength(255)]
        public string Image { get; set; }
    }
}
