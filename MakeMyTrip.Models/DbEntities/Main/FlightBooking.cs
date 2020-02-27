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
    [Table("FlightBookings",Schema="dbo")]
    public partial class FlightBooking
    {
		#region FlightBookingId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion FlightBookingId Annotations

        public int FlightBookingId { get; set; }

		#region TravellerId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion TravellerId Annotations

        public int TravellerId { get; set; }

		#region FlightDetailId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion FlightDetailId Annotations

        public int FlightDetailId { get; set; }

		#region OfferId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Offers","dbo","","OfferId")]
		#endregion OfferId Annotations

        public int OfferId { get; set; }

		#region Amount Annotations

        [Required]
		#endregion Amount Annotations

        public decimal Amount { get; set; }

		#region Offer Annotations

        [ForeignKey(nameof(OfferId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.Offer.FlightBookings))]
		#endregion Offer Annotations

        public virtual Offer Offer { get; set; }


        public FlightBooking()
        {
        }
	}
}