using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("vFlightDetails",Schema="dbo")]
    public partial class vFlightDetail
    {

        public string Origin { get; set; }


        public string Destination { get; set; }


        public string FlightDetails { get; set; }


        public string AvailableDay { get; set; }


        public string FlightName { get; set; }


        public decimal Amount { get; set; }


        public string Stop { get; set; }

		#region FlightId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion FlightId Annotations

        public int FlightId { get; set; }


        public vFlightDetail()
        {
        }
	}
}