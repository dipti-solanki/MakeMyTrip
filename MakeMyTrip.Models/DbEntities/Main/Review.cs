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
    [Table("Reviews",Schema="dbo")]
    public partial class Review
    {
		#region AppUserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("AppUsers","dbo","","AppUserId")]
		#endregion AppUserId Annotations

        public int AppUserId { get; set; }

		#region ReviewId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ReviewId Annotations

        public int ReviewId { get; set; }

		#region ReviewDetails Annotations

        [Required]
        [MaxLength(50)]
		#endregion ReviewDetails Annotations

        public string ReviewDetails { get; set; }

		#region AppUser Annotations

        [ForeignKey(nameof(AppUserId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.AppUser.Reviews))]
		#endregion AppUser Annotations

        public virtual AppUser AppUser { get; set; }

		#region CabDetails Annotations

        [InverseProperty("Review")]
		#endregion CabDetails Annotations

        public virtual ICollection<CabDetail> CabDetails { get; set; }

		#region HotelDetails Annotations

        [InverseProperty("Review")]
		#endregion HotelDetails Annotations

        public virtual ICollection<HotelDetail> HotelDetails { get; set; }

		#region FlightDetails Annotations

        [InverseProperty("Review")]
		#endregion FlightDetails Annotations

        public virtual ICollection<FlightDetail> FlightDetails { get; set; }

		#region BusDetails Annotations

        [InverseProperty("Review")]
		#endregion BusDetails Annotations

        public virtual ICollection<BusDetail> BusDetails { get; set; }


        public Review()
        {
			CabDetails = new HashSet<CabDetail>();
			HotelDetails = new HashSet<HotelDetail>();
			FlightDetails = new HashSet<FlightDetail>();
			BusDetails = new HashSet<BusDetail>();
        }
	}
}