using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("vBookedFlight",Schema="dbo")]
    public partial class vBookedFlight
    {
		#region TravellerId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion TravellerId Annotations

        public int TravellerId { get; set; }


        public string LastName { get; set; }


        public string FirstName { get; set; }


        public int FlightId { get; set; }


        public string FlightName { get; set; }


        public string FlightDetails { get; set; }


        public string Origin { get; set; }


        public string Destination { get; set; }


        public decimal Amount { get; set; }


        public string Stop { get; set; }


        public int FlightBookingId { get; set; }


        public vBookedFlight()
        {
        }
	}
}