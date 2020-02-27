using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("vBookedTrain",Schema="dbo")]
    public partial class vBookedTrain
    {
		#region TravellerId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion TravellerId Annotations

        public int TravellerId { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public int TrainId { get; set; }


        public string TrainName { get; set; }


        public string TrainDetails { get; set; }


        public string Class { get; set; }


        public string Origin { get; set; }


        public string Destination { get; set; }


        public System.DateTimeOffset Date { get; set; }


        public decimal Amount { get; set; }


        public int TrainBookingId { get; set; }


        public vBookedTrain()
        {
        }
	}
}