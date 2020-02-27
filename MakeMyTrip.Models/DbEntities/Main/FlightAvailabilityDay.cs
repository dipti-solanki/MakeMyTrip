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
    [Table("FlightAvailabilityDays",Schema="dbo")]
    public partial class FlightAvailabilityDay
    {
		#region FlightAvailableId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion FlightAvailableId Annotations

        public int FlightAvailableId { get; set; }

		#region AvailableDay Annotations

        [Required]
        [MaxLength(50)]
		#endregion AvailableDay Annotations

        public string AvailableDay { get; set; }

		#region FlightDetailId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FlightDetails","dbo","","FlightDetailId")]
		#endregion FlightDetailId Annotations

        public int FlightDetailId { get; set; }

		#region FlightDetail Annotations

        [ForeignKey(nameof(FlightDetailId))]
        [InverseProperty(nameof(MakeMyTrip.Models.Main.FlightDetail.FlightAvailabilityDays))]
		#endregion FlightDetail Annotations

        public virtual FlightDetail FlightDetail { get; set; }


        public FlightAvailabilityDay()
        {
        }
	}
}