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
    [Table("Rooms",Schema="dbo")]
    public partial class Room
    {
		#region RoomId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion RoomId Annotations

        public int RoomId { get; set; }

		#region HotelDetailId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("HotelDetails","dbo","","HotelDetailId")]
		#endregion HotelDetailId Annotations

        public int HotelDetailId { get; set; }

		#region RoomType Annotations

        [Required]
        [MaxLength(50)]
		#endregion RoomType Annotations

        public string RoomType { get; set; }

		#region Amount Annotations

        [Required]
		#endregion Amount Annotations

        public decimal Amount { get; set; }

		#region CheckIn Annotations

        [Required]
		#endregion CheckIn Annotations

        public System.DateTimeOffset CheckIn { get; set; }

		#region CheckOut Annotations

        [Required]
		#endregion CheckOut Annotations

        public System.DateTimeOffset CheckOut { get; set; }

		#region HotelDetail Annotations

        [ForeignKey(nameof(HotelDetailId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.HotelDetail.Rooms))]
		#endregion HotelDetail Annotations

        public virtual HotelDetail HotelDetail { get; set; }


        public Room()
        {
        }
	}
}