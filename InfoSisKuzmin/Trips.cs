using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSystem
{
    [Table("trips", Schema = "pm11")]
    public class Trips
    {
        [Key]
        [Column("trip_id")]
        public int TripId { get; set; }

        [Column("route_id")]
        public long RouteId { get; set; }

        [Column("vehicle_id")]
        public long VehicleId { get; set; }

        [Column("driver_id")]
        public long DriverId { get; set; }

        [Column("client_id")]
        public long ClientId { get; set; }

        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [Column("cargo_description")]
        [StringLength(255)]
        public string CargoDescription { get; set; }

        [Column("cargo_weight")]
        public decimal CargoWeight { get; set; }

        [Column("status")]
        [StringLength(20)]
        public string Status { get; set; }

        [Column("cost")]
        public decimal Cost { get; set; }
    }
}
