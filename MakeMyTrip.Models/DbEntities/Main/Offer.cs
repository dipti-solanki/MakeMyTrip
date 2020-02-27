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
    [Table("Offers",Schema="dbo")]
    public partial class Offer
    {
		#region OfferId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion OfferId Annotations

        public int OfferId { get; set; }

		#region OfferName Annotations

        [Required]
        [MaxLength(50)]
		#endregion OfferName Annotations

        public string OfferName { get; set; }

		#region Discount Annotations

        [Required]
		#endregion Discount Annotations

        public decimal Discount { get; set; }

		#region TrainBookings Annotations

        [InverseProperty("Offer")]
		#endregion TrainBookings Annotations

        public virtual ICollection<TrainBooking> TrainBookings { get; set; }

		#region BusBookings Annotations

        [InverseProperty("Offer")]
		#endregion BusBookings Annotations

        public virtual ICollection<BusBooking> BusBookings { get; set; }

		#region CabBookings Annotations

        [InverseProperty("Offer")]
		#endregion CabBookings Annotations

        public virtual ICollection<CabBooking> CabBookings { get; set; }

		#region FlightBookings Annotations

        [InverseProperty("Offer")]
		#endregion FlightBookings Annotations

        public virtual ICollection<FlightBooking> FlightBookings { get; set; }

		#region HotelBookings Annotations

        [InverseProperty("Offer")]
		#endregion HotelBookings Annotations

        public virtual ICollection<HotelBooking> HotelBookings { get; set; }


        public Offer()
        {
			TrainBookings = new HashSet<TrainBooking>();
			BusBookings = new HashSet<BusBooking>();
			CabBookings = new HashSet<CabBooking>();
			FlightBookings = new HashSet<FlightBooking>();
			HotelBookings = new HashSet<HotelBooking>();
        }
	}
}