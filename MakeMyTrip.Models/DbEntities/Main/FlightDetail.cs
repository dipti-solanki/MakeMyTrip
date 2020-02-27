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
    [Table("FlightDetails",Schema="dbo")]
    public partial class FlightDetail
    {
		#region FlightDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion FlightDetailId Annotations

        public int FlightDetailId { get; set; }

		#region FlightId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion FlightId Annotations

        public int FlightId { get; set; }

		#region FlightDetails Annotations

        [Required]
        [MaxLength(50)]
		#endregion FlightDetails Annotations

        public string FlightDetails { get; set; }

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

		#region Stop Annotations

        [MaxLength(50)]
		#endregion Stop Annotations

        public string Stop { get; set; }

		#region Review Annotations

        [ForeignKey(nameof(ReviewId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.Review.FlightDetails))]
		#endregion Review Annotations

        public virtual Review Review { get; set; }

		#region FlightAvailabilityDays Annotations

        [InverseProperty("FlightDetail")]
		#endregion FlightAvailabilityDays Annotations

        public virtual ICollection<FlightAvailabilityDay> FlightAvailabilityDays { get; set; }


        public FlightDetail()
        {
			FlightAvailabilityDays = new HashSet<FlightAvailabilityDay>();
        }
	}
}