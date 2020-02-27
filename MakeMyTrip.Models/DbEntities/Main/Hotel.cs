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
    [Table("Hotels",Schema="dbo")]
    public partial class Hotel
    {
		#region HotelId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion HotelId Annotations

        public int HotelId { get; set; }

		#region HotelName Annotations

        [Required]
        [MaxLength(50)]
		#endregion HotelName Annotations

        public string HotelName { get; set; }

		#region CityId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Cities","dbo","","CityId")]
		#endregion CityId Annotations

        public int CityId { get; set; }

		#region City Annotations

        [ForeignKey(nameof(CityId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.City.Hotels))]
		#endregion City Annotations

        public virtual City City { get; set; }

		#region Localities Annotations

        [InverseProperty("Hotel")]
		#endregion Localities Annotations

        public virtual ICollection<Locality> Localities { get; set; }

		#region HotelDetails Annotations

        [InverseProperty("Hotel")]
		#endregion HotelDetails Annotations

        public virtual ICollection<HotelDetail> HotelDetails { get; set; }


        public Hotel()
        {
			Localities = new HashSet<Locality>();
			HotelDetails = new HashSet<HotelDetail>();
        }
	}
}