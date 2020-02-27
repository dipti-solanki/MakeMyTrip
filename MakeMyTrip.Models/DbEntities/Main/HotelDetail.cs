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
    [Table("HotelDetails",Schema="dbo")]
    public partial class HotelDetail
    {
		#region HotelDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion HotelDetailId Annotations

        public int HotelDetailId { get; set; }

		#region HotelId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Hotels","dbo","","HotelId")]
		#endregion HotelId Annotations

        public int HotelId { get; set; }

		#region HotelDetails Annotations

        [Required]
        [MaxLength(50)]
		#endregion HotelDetails Annotations

        public string HotelDetails { get; set; }

		#region Floors Annotations

        [Required]
        [MaxLength(50)]
		#endregion Floors Annotations

        public string Floors { get; set; }

		#region ReviewId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Reviews","dbo","","ReviewId")]
		#endregion ReviewId Annotations

        public int ReviewId { get; set; }

		#region StarCategory Annotations

        [Required]
        [MaxLength(50)]
		#endregion StarCategory Annotations

        public string StarCategory { get; set; }

		#region UserRating Annotations

        [Required]
        [MaxLength(50)]
		#endregion UserRating Annotations

        public string UserRating { get; set; }

		#region Hotel Annotations

        [ForeignKey(nameof(HotelId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.Hotel.HotelDetails))]
		#endregion Hotel Annotations

        public virtual Hotel Hotel { get; set; }

		#region Review Annotations

        [ForeignKey(nameof(ReviewId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.Review.HotelDetails))]
		#endregion Review Annotations

        public virtual Review Review { get; set; }

		#region Rooms Annotations

        [InverseProperty("HotelDetail")]
		#endregion Rooms Annotations

        public virtual ICollection<Room> Rooms { get; set; }


        public HotelDetail()
        {
			Rooms = new HashSet<Room>();
        }
	}
}