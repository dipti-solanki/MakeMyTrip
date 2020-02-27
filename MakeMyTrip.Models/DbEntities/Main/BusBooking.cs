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
    [Table("BusBookings",Schema="dbo")]
    public partial class BusBooking
    {
		#region BusBookingId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion BusBookingId Annotations

        public int BusBookingId { get; set; }

		#region TravellerId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion TravellerId Annotations

        public int TravellerId { get; set; }

		#region BusDetailId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion BusDetailId Annotations

        public int BusDetailId { get; set; }

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
        [InverseProperty(nameof(MakeMyTrip.Models.Main.Offer.BusBookings))]
		#endregion Offer Annotations

        public virtual Offer Offer { get; set; }


        public BusBooking()
        {
        }
	}
}