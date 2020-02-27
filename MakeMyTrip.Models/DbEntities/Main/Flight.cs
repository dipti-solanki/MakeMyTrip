using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.Models.Enums.Main;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("Flights",Schema="dbo")]
    public partial class Flight
    {
		#region FlightId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion FlightId Annotations

        public int FlightId { get; set; }

		#region FlightName Annotations

        [Required]
        [MaxLength(50)]
		#endregion FlightName Annotations

        public string FlightName { get; set; }


        public Flight()
        {
        }
	}
}