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
    [Table("Cities",Schema="dbo")]
    public partial class City
    {
		#region CityId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CityId Annotations

        public int CityId { get; set; }

		#region CityName Annotations

        [Required]
        [MaxLength(50)]
		#endregion CityName Annotations

        public string CityName { get; set; }

		#region Hotels Annotations

        [InverseProperty("City")]
		#endregion Hotels Annotations

        public virtual ICollection<Hotel> Hotels { get; set; }

		#region Localities Annotations

        [InverseProperty("City")]
		#endregion Localities Annotations

        public virtual ICollection<Locality> Localities { get; set; }


        public City()
        {
			Hotels = new HashSet<Hotel>();
			Localities = new HashSet<Locality>();
        }
	}
}