using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("vBookedHotel",Schema="dbo")]
    public partial class vBookedHotel
    {
		#region TravellerId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion TravellerId Annotations

        public int TravellerId { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string HotelName { get; set; }


        public int HotelId { get; set; }


        public string HotelDetails { get; set; }


        public string StarCategory { get; set; }


        public string UserRating { get; set; }


        public int ReviewId { get; set; }


        public string Floors { get; set; }


        public int HotelBookingId { get; set; }


        public string RoomType { get; set; }


        public decimal Amount { get; set; }


        public System.DateTimeOffset CheckIn { get; set; }


        public System.DateTimeOffset CheckOut { get; set; }


        public vBookedHotel()
        {
        }
	}
}