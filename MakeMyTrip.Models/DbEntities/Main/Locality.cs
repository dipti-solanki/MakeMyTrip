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
    [Table("Localities",Schema="dbo")]
    public partial class Locality
    {
		#region LocalityId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion LocalityId Annotations

        public int LocalityId { get; set; }

		#region LocalityName Annotations

        [Required]
        [MaxLength(50)]
		#endregion LocalityName Annotations

        public string LocalityName { get; set; }

		#region HotelId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Hotels","dbo","","HotelId")]
		#endregion HotelId Annotations

        public int HotelId { get; set; }

		#region CityId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Cities","dbo","","CityId")]
		#endregion CityId Annotations

        public int CityId { get; set; }

		#region City Annotations

        [ForeignKey(nameof(CityId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.City.Localities))]
		#endregion City Annotations

        public virtual City City { get; set; }

		#region Hotel Annotations

        [ForeignKey(nameof(HotelId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.Hotel.Localities))]
		#endregion Hotel Annotations

        public virtual Hotel Hotel { get; set; }


        public Locality()
        {
        }
	}
}