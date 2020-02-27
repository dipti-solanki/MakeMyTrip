using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("vBookedCab",Schema="dbo")]
    public partial class vBookedCab
    {
		#region TravellerId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion TravellerId Annotations

        public int TravellerId { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public int CabId { get; set; }


        public string CabName { get; set; }


        public string CabDetails { get; set; }


        public string Facilities { get; set; }


        public decimal Amount { get; set; }


        public string Origin { get; set; }


        public string Destination { get; set; }


        public int CabBookingId { get; set; }


        public vBookedCab()
        {
        }
	}
}