using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using MakeMyTrip.BoundedContext.SqlContext;
namespace MakeMyTrip.Models.Main
{
    [Table("vHotelDetails",Schema="dbo")]
    public partial class vHotelDetail
    {

        public string CityName { get; set; }

		#region CityId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CityId Annotations

        public int CityId { get; set; }


        public string HotelDetails { get; set; }


        public string Floors { get; set; }


        public string HotelName { get; set; }


        public string StarCategory { get; set; }


        public string UserRating { get; set; }


        public int HotelId { get; set; }


        public string RoomType { get; set; }


        public decimal Amount { get; set; }


        public System.DateTimeOffset CheckIn { get; set; }


        public System.DateTimeOffset CheckOut { get; set; }


        public int TravellerId { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public vHotelDetail()
        {
        }
	}
}