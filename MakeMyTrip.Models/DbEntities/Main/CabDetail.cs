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
    [Table("CabDetails",Schema="dbo")]
    public partial class CabDetail
    {
		#region CabDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CabDetailId Annotations

        public int CabDetailId { get; set; }

		#region CabId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Cabs","dbo","","CabId")]
		#endregion CabId Annotations

        public int CabId { get; set; }

		#region CabDetails Annotations

        [Required]
        [MaxLength(50)]
		#endregion CabDetails Annotations

        public string CabDetails { get; set; }

		#region Facilities Annotations

        [Required]
        [MaxLength(50)]
		#endregion Facilities Annotations

        public string Facilities { get; set; }

		#region Amount Annotations

        [Required]
		#endregion Amount Annotations

        public decimal Amount { get; set; }

		#region ReviewId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("Reviews","dbo","","ReviewId")]
		#endregion ReviewId Annotations

        public int ReviewId { get; set; }

		#region Origin Annotations

        [Required]
        [MaxLength(50)]
		#endregion Origin Annotations

        public string Origin { get; set; }

		#region Destination Annotations

        [Required]
        [MaxLength(50)]
		#endregion Destination Annotations

        public string Destination { get; set; }

		#region Cab Annotations

        [ForeignKey(nameof(CabId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.Cab.CabDetails))]
		#endregion Cab Annotations

        public virtual Cab Cab { get; set; }

		#region Review Annotations

        [ForeignKey(nameof(ReviewId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.Review.CabDetails))]
		#endregion Review Annotations

        public virtual Review Review { get; set; }

		#region CabAvailabilityDays Annotations

        [InverseProperty("CabDetail")]
		#endregion CabAvailabilityDays Annotations

        public virtual ICollection<CabAvailabilityDay> CabAvailabilityDays { get; set; }


        public CabDetail()
        {
			CabAvailabilityDays = new HashSet<CabAvailabilityDay>();
        }
	}
}