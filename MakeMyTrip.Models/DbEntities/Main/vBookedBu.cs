using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("vBookedBus",Schema="dbo")]
    public partial class vBookedBu
    {
		#region BusId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion BusId Annotations

        public int BusId { get; set; }


        public string BusName { get; set; }


        public string BusDetails { get; set; }


        public string Origin { get; set; }


        public string Destination { get; set; }


        public int LeftSeats { get; set; }


        public decimal Amount { get; set; }


        public string Transport { get; set; }


        public string BusType { get; set; }


        public int BusBookingId { get; set; }


        public int TravellerId { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public vBookedBu()
        {
        }
	}
}